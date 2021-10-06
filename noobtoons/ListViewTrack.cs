// This is a ListViewItem that represents a song.
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

using noobtoons_backend;
using inoobtoons;

namespace noobtoons {
    public class ListViewTrack :  ListViewItem {
        private ITrack track_data;

        public ListViewTrack(string[] column_values) : base (column_values) {
            
        }

        public static ListViewTrack list_view_track_factory(TagLib.File taginfo, string[] column_values, string path) {
            ListViewTrack list_view_track = new ListViewTrack(column_values);
            list_view_track.track_data = new Track(taginfo,  path);
            return list_view_track;
        }

        public ITrack Track {
            get {
                return this.track_data;
            }

        }


    }
}
