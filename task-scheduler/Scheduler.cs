// This is a task (delegate) scheduler that makes multithreading easier, and 
// uses the .NET CLR thread pool.
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
using System.Threading;

namespace task_scheduler {

    public class Scheduler {
        private static readonly object singleton_padlock = new object();
        private readonly object scheduling_padlock;
        private static Scheduler scheduler = null;
        private System.Threading.Thread scheduler_thread;
        private List<Task> task_list = null;

        public bool SchedulerStarted {
            get {
                return
                    scheduler.scheduler_thread.ThreadState
                        != ThreadState.Unstarted;
            }
        }


        private Scheduler() {

            this.task_list = new List<Task>();
            this.scheduling_padlock = new object();
            this.scheduler_thread = new System.Threading.Thread(this.schedulerer);
            Console.WriteLine("Scheduler Created");
        }

        public static Scheduler getSingletonInstance() {
            lock (singleton_padlock) {
                if (null == scheduler) {
                    scheduler = new Scheduler();
                }
            }
            return scheduler;
        }

        public static void start_schedulerer() {
            if (null != scheduler) {
                scheduler.scheduler_thread.Start();
                Console.WriteLine("Scheduling Thread Started");
            }
        }

        public void start_this_schedulerer() {          
            this.scheduler_thread.Start();
            Console.WriteLine("Scheduling Thread Started");
        }

        public static void schedule_task(Task task) {
            if (null != task ){ //&& scheduler.SchedulerStarted) {
                lock (scheduler.scheduling_padlock) {
                    Console.WriteLine("Task being scheduled, with following ID: " + task.Task_ID);
                    scheduler.task_list.Add(task);
                    System.Threading.Monitor.Pulse(scheduler.scheduling_padlock);
                }
            }
        }

        public void schedulerer() {
            lock (scheduling_padlock) {
                while (true) {

                    Console.WriteLine("\n\n---------------------------------\nRe-interating in scheduling loop... \n---------------------------------\n");


                    while (this.task_list.Count <= 0) {
                        Console.WriteLine("Count is : " + this.task_list.Count + " Waiting for new task to be added...");
                        System.Threading.Monitor.Wait(scheduling_padlock);
                    }

                    Console.WriteLine("Done Waiting... Time to Schedule...");

                    Task next = task_list[0];
                    Console.WriteLine("About to Run Task With ID: " + next.Task_ID);

                    System.Threading.ThreadPool.QueueUserWorkItem(
                        delegate(object o) {

                            try {
                                next.execute();
                                Console.WriteLine("Finished Executing Task With ID: " + next.Task_ID);
                                //scheduler.task_list[0].execute();
                            } catch (Exception ex) {
                                Console.WriteLine("Task With ID " + next.Task_ID + " threw an exception: " + ex.Data);
                                // Very Nice
                                // Interlocked.Exchange<Exception>(ref first.exception, ex);
                            }
                            // Interlocked.Exchange(ref first.completed, 1);

                        });


                    scheduler.task_list.RemoveAt(0);
                }
            }
        }


    }
}
