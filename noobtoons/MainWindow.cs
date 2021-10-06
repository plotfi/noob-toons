// The shell for noob-toons. 
// Avoid using non-gui related code here. 
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

// As of April 2008, this class is a total hack. It just has a decent layout.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;

using inoobtoons;
using noobtoons_backend;


  
namespace noobtoons {
    public partial class MainWindow : Form {

        private VLCAudioEngine playlistmanager;
        private readonly object atomic_update_screen;

        public MainWindow() {
            InitializeComponent();
            playlistmanager = new VLCAudioEngine();
            atomic_update_screen = new object();
            playlistmanager.PluginPath = "C:\\Program Files (x86)\\VideoLAN\\VLC\\plugins";
        }

        private void filesToolStripMenuItem1_Click(object sender, EventArgs e) {
            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.Multiselect = true;
             if (open_file_dialog.ShowDialog() == DialogResult.OK) { 
                /// TODO: Bad File exception, do not select non-music files, taglib will hate you

                foreach (string media_filename in open_file_dialog.FileNames) {
                    TagLib.File taginfo = TagLib.File.Create(media_filename);
                    ListViewTrack track = ListViewTrack.list_view_track_factory(
                        taginfo,     
                        new string[] {
                            taginfo.Tag.Track.ToString(), 
                            taginfo.Tag.Title, 
                            taginfo.Tag.Album, 
                            taginfo.Tag.FirstArtist, 
                            taginfo.MimeType,
                            media_filename 
                        },
                        media_filename);
                    playlist_view.Items.Add(track);
                }
            }
        }

 





        private void info_tab_view_SelectedIndexChanged(object sender, EventArgs e) {
           /* if (playlist_view.SelectedItems.Count > 0) {
                string artist = playlist_view.SelectedItems[0].SubItems[3].Text;
                string song = playlist_view.SelectedItems[0].SubItems[1].Text;
                if (info_tab_view.SelectedTab.Text == "Lyrics") {
                    lyrics_browser.DocumentText = Lyricwiki.lyrics_html(artist, song);
                } else if (info_tab_view.SelectedTab.Text == "Wikipedia") {
                    string html = Wikipedia.wikipedia_page_content(artist);
                    html = html.Replace("href=\"/wiki/", "href=\"http://en.wikipedia.org/wiki/");
                    wikipedia_browser.DocumentText = html;
                    

                }// else if (info_tab_view.SelectedTab.Text == "Album Art") {
                    string arthtml = "<html><head><title>" + artist + " Album Art Page" + "</title></head><body>";
                    foreach(XmlNode node in  Amazon.medium_image_elements(artist)) {
                        arthtml += "<img src=\"" + node.InnerText + "\"/>&nbsp;&nbsp;&nbsp;";
                    }
                    arthtml += "</body></html>";

                    art_browser.DocumentText = arthtml;
                //}
            }*/
        }

        private void stop_button_Click(object sender, EventArgs e) {
            playlistmanager.stop();
        }

        private void play_button_Click(object sender, EventArgs e) {
            Console.WriteLine("about to play");
            if (playlist_view.SelectedItems.Count > 0) {
                playlistmanager.play(((ListViewTrack)(playlist_view.Items[playlist_view.SelectedIndices[0]])).Track);
            }
        }

        private void previous_button_Click(object sender, EventArgs e) {
            /*if (playlistmanager.previous()) {
                foreach (ListViewItem item in playlist_view.SelectedItems) {
                    item.Selected = false;
                }
                playlist_view.FindItemWithText(playlistmanager.CurrentTrack.Path).Selected = true;
                playlist_view.Select();
            } else {*/
                int playlist_count = playlist_view.Items.Count;
                int selected_count = playlist_view.SelectedIndices.Count;
                if (playlist_count > 1 && 
                    selected_count >= 1 &&
                    playlist_view.SelectedIndices[0] > 0
                    ) {
                    ListViewTrack previous =  (ListViewTrack)(playlist_view.Items[playlist_view.SelectedIndices[0] - 1]);
                    foreach(ListViewTrack track in playlist_view.Items) {
                        track.Selected = false;
                    }
                    previous.Selected = true;
                    playlistmanager.play(previous.Track);
                    playlist_view.Select();
                }
           // }
        }

        private void next_button_Click(object sender, EventArgs e) {
           /* if (playlistmanager.next()) {
                foreach (ListViewItem item in playlist_view.SelectedItems) {
                    item.Selected = false;
                }
                playlist_view.FindItemWithText(playlistmanager.CurrentTrack.Path).Selected = true;
                playlist_view.Select();
            } else {*/
                int playlist_count = playlist_view.Items.Count;
                int selected_count = playlist_view.SelectedIndices.Count;
                if (playlist_count > 1 && selected_count >= 1 && playlist_view.SelectedIndices[0] < playlist_count - 1) {
                    playlist_view.Items[playlist_view.SelectedIndices[0] + 1].Selected = true;
                    playlistmanager.play(((ListViewTrack)(playlist_view.Items[playlist_view.SelectedIndices[0] + 1])).Track);
                    playlist_view.Items[playlist_view.SelectedIndices[0]].Selected = false;
                    playlist_view.Select();
                }
            //}
        }

        private void volume_slider_Scroll(object sender, EventArgs e) {
            lock (atomic_update_screen) {
                playlistmanager.Volume = volume_slider.Value;
            }
        }

        private void seek_slider_Scroll(object sender, EventArgs e) {
            
            int volume = playlistmanager.Volume;
            playlistmanager.Volume = 0;
            playlistmanager.Position = (float)((float)(seek_slider.Value) / (float)(seek_slider.Maximum));
            playlistmanager.Volume = volume;
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (playlistmanager != null) {
                volume_slider.Value = playlistmanager.Volume % 100;
                seek_slider.Value = (int)(playlistmanager.Position * seek_slider.Maximum);
           }
        }

        private void playpause_button_Click(object sender, EventArgs e) {
            if (playlistmanager.IsPlaying) {
                playlistmanager.mute();
                timer1.Enabled = false;
            } else {
                playlistmanager.unmute();
                timer1.Enabled = true;
            }

            playlistmanager.pause();
        }

 

        private void seek_slider_MouseDown(object sender, MouseEventArgs e) {
            timer1.Stop();
            playlistmanager.mute();
        }

        private void seek_slider_MouseUp(object sender, MouseEventArgs e) {
            playlistmanager.unmute();
            timer1.Start();
        }

        private void splitContainer1_Resize(object sender, EventArgs e) {
            this.Refresh();
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e) {
            this.Refresh();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            //webBrowser1.DocumentText = "<html><body><b>YAya!</b></body></html>";
        }
     }
}