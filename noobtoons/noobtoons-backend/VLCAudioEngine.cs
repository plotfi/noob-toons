// A VLC implementation of the IAudioEngine interface.
// Copyright (C) 2008  Puyan Lotfi
// plotfi@gmail.com
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using inoobtoons;
using System.Collections.Generic;
using Atx.LibVLC;


namespace noobtoons_backend {
    public class VLCAudioEngine : IAudioEngine {

        private VlcInstance vlcinstance;
        private readonly object atomic_audio_event_lock;
        private readonly object atomic_engine_fields;
        private bool plugin_path_set;
        private List<ITrack> played_songs;
        private int current_index;

        public VLCAudioEngine() {
            this.vlcinstance = new VlcInstance(new VlcConfig());
            this.atomic_audio_event_lock = new object();
            this.atomic_engine_fields = new object();
            plugin_path_set = false;
            played_songs = new List<ITrack>();
            current_index = 0;
        }

        public string PluginPath {
            set {
                if (!plugin_path_set) {
                    plugin_path_set = true;
                    vlcinstance.VlcConfig.PluginPath = value;
                }
            }
        }

        #region IAudioEngine Members

        public void play(ITrack track) {
            lock (atomic_engine_fields) {
                if (this.current_index > 0) {
                    this.current_index++;
                    played_songs.Insert(this.current_index, track);
                } else {
                    played_songs.Add(track);
                    this.current_index = played_songs.Count - 1;
                }

                this.play();
            }
        }

        public void play() {
            lock (atomic_audio_event_lock) {
                vlcinstance.VlcPlaylist.Play(vlcinstance.VlcPlaylist.Add(played_songs[current_index].Path));
            }
        }

        public void pause() {
            lock (atomic_audio_event_lock) {
                vlcinstance.VlcPlaylist.Pause();
            }
        }

        public void stop() {
            lock (atomic_audio_event_lock) {
                vlcinstance.VlcPlaylist.Stop();

            }
        }

        public bool next() {
            if (this.played_songs.Count > 1 &&
                current_index > 0 &&
                current_index < this.played_songs.Count - 1
                ) {
                lock (atomic_engine_fields) {
                    this.current_index++;
                    this.play();
                }
                return true;
            } else {
                return false;
            }
        }

        public bool previous() {
            if (this.played_songs.Count > 1 && current_index > 0) {
                lock (atomic_engine_fields) {
                    this.current_index--;
                    this.play();

                }
                return true;
            } else {
                return false;
            }
        }

        public float Position {
            get {
                lock (this.atomic_audio_event_lock) {
                    if (vlcinstance.VlcPlaylist.IsPlaying) {
                        return vlcinstance.VlcInput.Position;
                    } else {
                        return 0.0f;
                    }
                }
            }

            set {
                lock (this.atomic_audio_event_lock) {
                    if (0f <= value && value <= 0.99f && vlcinstance.VlcPlaylist.IsPlaying) {
                        vlcinstance.VlcInput.Position = value;
                    }
                }
            }
        }

        public void mute() {
            lock (this.atomic_audio_event_lock) {
                this.vlcinstance.Mute = true;
            }
        }

        public void unmute() {
            lock (this.atomic_audio_event_lock) {
                this.vlcinstance.Mute = false;
            }
        }

        public int Volume {
            get {
                lock (this.atomic_audio_event_lock) {
                    return vlcinstance.Volume;
                }
            }


            set {
                lock (this.atomic_audio_event_lock) {
                    if (0 <= value && value <= 99) {
                        vlcinstance.Volume = value;
                    }
                }
            }
        }

        public ITrack CurrentTrack {
            get {
                if (played_songs.Count > 0) {
                    lock (this.atomic_audio_event_lock) {
                        return this.played_songs[this.current_index];
                    }
                } else {
                    return null;
                }
            }
        }

        public bool IsPlaying {
            get {
                lock (this.atomic_audio_event_lock) {
                    return vlcinstance.VlcPlaylist.IsPlaying;
                }
            }
        }



        #endregion

    }
}
