// Example Class
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

// This is an example class, it isn't actually evil.

using System;

namespace task_scheduler {
    public class EvilTaskSpecialization : TaskSpecializationComponent {

        private EvilEventArgs e;

        public EvilTaskSpecialization(string input_data) {
            e = new EvilEventArgs();
            e.Input_Data = input_data;
        }

        #region TaskSpecializationComponent Members

        public void SpecializedTaskMethod(object sender, EventArgs e) {
            Console.WriteLine(((EvilEventArgs)e).Input_Data);
        }

        public EventArgs event_args {
            get { return this.e; }
        }

        #endregion
    }
}
