using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($" id : {Id}\n Name : {Name}\n Salary : {Salary} ");
        }
        
    }
}
