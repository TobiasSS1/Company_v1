using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker:Employee
    {
        string Skill;



        public Worker(string navn, int Salary, string Skill):base(navn, Salary)
        {
            this.Skill = Skill;
        }


    }
}
