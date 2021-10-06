// This represents a task to be scheduled.
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

namespace task_scheduler {
    
    public delegate void TaskEventHandler(object sender, EventArgs e);
    
	public class Task {	
		public event TaskEventHandler finish_event;
        private TaskSpecializationComponent task_specialization;
		private UInt32 id;
		private static UInt32 id_count = 0;

        public TaskSpecializationComponent Task_Specialization {
		    get {
                return task_specialization;
		    }
		}

        public UInt32 Task_ID {
            get {
                return id;
            }
        }
		
		private Task() {}

        public static Task Task_Factory(TaskSpecializationComponent task_specialization) {
            if (null == task_specialization) return null; // TODO: throw exception
			Task task = new Task();
            task.task_specialization = task_specialization;
            task.finish_event += new TaskEventHandler(task_specialization.SpecializedTaskMethod);
			task.id = Task.id_count++;
			return task;
		}
		
		public void execute() {
            Console.WriteLine("Task ID " + this.Task_ID + " is being executed.");
            this.finish_event(this, this.task_specialization.event_args);
		}
	}
}
