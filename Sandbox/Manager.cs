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

        public Manager():base("Lars", 800)
        {
            this.Bonus = 2000;
            this.hoursworked = 181; 
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
