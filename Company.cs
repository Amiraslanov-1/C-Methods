using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Company
    {

        public List<string> Employees = new List<string>();

        public List<string>  FindEmployeesByName(string name)
        {
            List<string> NewEmployees = new List<string>();
            foreach (var employe in  Employees)
            {
                if (employe.Contains(name))
                {
                    NewEmployees.Add(employe);
                }
            }

            return NewEmployees;
        }


       
    }
}
