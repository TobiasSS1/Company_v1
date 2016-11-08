using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager:Employee
    {
        protected int Bonus;
        private int hoursworked;

        public Manager(string navn, int Salary, int Bonus, int hoursworked):base(navn, Salary)
        {
            this.Bonus = Bonus;
            this.hoursworked = hoursworked; 
        }

        public override int GetSalaryPerMonth()
        {
            if (hoursworked >= 180)
            {
                return base.GetSalaryPerMonth() + Bonus;
            }

            return base.GetSalaryPerMonth();
        }

    }
}
