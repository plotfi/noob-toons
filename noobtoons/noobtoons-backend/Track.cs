// Represents a track.
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

namespace noobtoons_backend {
    public class Track : ITrack {

        private TagLib.File taginfo;
        private string filepath;

        private Track() { }

        public Track(TagLib.File taginfo, string path) {
            this.taginfo = taginfo;
            this.filepath = path;
        }

        #region ITrack Members

        public string Path {
            get {
                return this.filepath;
            }
        }

        #endregion
    }
}
