using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager:Employee
    {
        private int Bonus;
        private int hoursworked;

        public Manager(string navn, int salary, int Bonus, int hoursworked):base(navn, salary)
        {
            this.Bonus = Bonus;
            this.hoursworked = hoursworked; 

        }
    }
}
