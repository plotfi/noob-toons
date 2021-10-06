// This is a ListView class with the concept of a playlist. 
// Note: it does not use IPlaylist, and probably never will.
// The first implementation of this interface used libvlc-sharp
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
using System.Windows.Forms;

using inoobtoons;
using noobtoons_backend;

namespace noobtoons {
    public class ListViewPlaylist : ListView {
        private IAudioEngine audio_engine;

        public ListViewPlaylist(IAudioEngine audio_engine) {
            if (null == audio_engine) {
                throw new Exception();
            }
            this.audio_engine = audio_engine;
        }


        void play() {
            audio_engine.play((ITrack)(this.Items));
        }

        void pause() {
            audio_engine.pause();
        }

        void stop() {
            audio_engine.stop();
        }



        /*
        int Volume {
            get {
                return 0;
            }

            set {

            }
        }

        float Position {
            get {
            
            }
            set {
            
            }
        }
         * */

    }
}
