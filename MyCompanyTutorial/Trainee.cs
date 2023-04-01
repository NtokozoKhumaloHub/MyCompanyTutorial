using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyTutorial
{
    internal class Trainee : Employee
    {
        protected bool isWorking = false;
        protected bool isWork = false;
        protected static int hoursDuration = 0;
        public int WorkingHours { get; set; }        
        public int SchoolHours { get; set; }

        Timer timer;

        public Trainee() { }

        public Trainee(int workingHours, int schoolHours)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn() 
        { 
            isWork = false;
            if (!isWorking)
            {
                isWorking = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        public void Stop()
        {
            if (isWorking)
            {
                hoursDuration = 0;
                isWorking = false;
                timer.Dispose();
                Console.WriteLine($"I have stopped learning");
            }
        }

        public void TimerCallback(object o)
        {
            int localwork;
            string temp;
            if (isWork)
            {
                localwork = WorkingHours;
                temp = "Working";
            }
            else
            {
                localwork = SchoolHours;
                temp = "Learning";
            }       

            if (hoursDuration < localwork)
            {
                hoursDuration++;
                Console.WriteLine($"I am {temp} - {hoursDuration}");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public override void Work()
        {
            isWork=true; 
            if (!isWorking)
            {
                isWorking = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
    }
}
