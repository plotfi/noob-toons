// This is an interface describing the methods of an audio engine wrapper.
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

namespace inoobtoons {
    public interface IAudioEngine {
        void play(ITrack track);
        void play();
        void pause();
        void stop();
        bool next();
        bool previous();
        void mute();
        void unmute();
        int Volume { get; set; }
        float Position { get; set; }
        ITrack CurrentTrack { get; }
        bool IsPlaying { get; }
    }
}
