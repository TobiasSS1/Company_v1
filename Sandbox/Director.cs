using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Director : Manager

    {

        public Director(string navn, int Salary, int hoursworked) : base(navn, Salary, 2000, hoursworked)
        {
            
        }

        public override int GetSalaryPerMonth()
        {

            return base.GetSalaryPerMonth() + Bonus;
        }
    }
}
