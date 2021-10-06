// This is an interface describing a playlist.
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
using System.Collections.Generic;

namespace inoobtoons {
    public interface IPlayList {
        ITrack current_track { get; }
        ITrack next_track { get; }
        ITrack previous_track { get; }
        void queue_track(ITrack track);
        void queue_tracks(List<ITrack> tracks);
        List<ITrack> search_playlist(string search_string);
    }
}
