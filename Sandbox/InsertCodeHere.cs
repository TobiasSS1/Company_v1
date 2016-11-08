using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Add you test of the Employee class and derived classes here

            List<Employee> WorkerList = new List<Employee>();
            Employee anna = new Employee("Anna", 1000);
            Employee ole = new Employee("Ole", 2000);
            Employee kasper = new Employee("Kasper", 1500);

            Worker jens = new Worker("Jens", 83000, "Politiker");
            Worker sasha = new Worker("Sasha", 2000, "Hjerne kirug");
            Worker mette = new Worker("Mette", 5000, "Køleskabs magnet");

            Manager lars = new Manager("Lars", 5000, 300, 200);
            Manager mads = new Manager("Mads", 3000, 100, 50);
            Manager spiderman = new Manager("SpiderMan", 8000, 1000, 800);

            Director karl = new Director("Karl", 5800, 20);
            Director jette = new Director("Jette", 3000, 160);
            Director tobias = new Director("Tobias", 9000, 200);

            WorkerList.Add(anna);
            WorkerList.Add(ole);
            WorkerList.Add(kasper);

            WorkerList.Add(jens);
            WorkerList.Add(sasha);
            WorkerList.Add(mette);

            WorkerList.Add(lars);
            WorkerList.Add(mads);
            WorkerList.Add(spiderman);

            WorkerList.Add(karl);
            WorkerList.Add(jette);
            WorkerList.Add(tobias);

            foreach (var l in WorkerList)
            {
                Console.WriteLine($"Navn: {l.GetName()}  Løn: {l.GetSalaryPerMonth()} ");
            }


    
            // The LAST line of code should be ABOVE this line
        }
    }
}
