using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Employe
    {
        static int _id;
        public static int ID { get => _id;}
        public Employe()
        {
            _id++;
        }

        public Employe(string name,int salary)
        {
            Name = name;
            Salary = salary;
                
        }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Length { get; internal set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} \n Salary: {Salary}");
        }




    }
}
