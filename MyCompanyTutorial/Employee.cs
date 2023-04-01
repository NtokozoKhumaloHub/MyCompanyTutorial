using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyTutorial
{
    internal class Employee
    {
        //protected bool isWorking = false;
        //protected static int hoursDuration = 0;

        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected decimal Salary { get; set; }

        //Timer timer;

        public Employee()
        {

        }

        public Employee(string name, string firstName, decimal salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {

        }

        public  void Pause()
        {

        }

    }
}
