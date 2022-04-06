using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\tu7mxp4w4\source\repos\ConsoleApp32\ConsoleApp1\";
            if (!Directory.Exists(path + "Files"))
            {
                Directory.CreateDirectory(path + "Files");
            }

            if (!File.Exists(path + @"Files\Database.json"))
            {
                File.Create(path + @"Files\Database.json");
            }

            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Nazim",
                Salary = 250
            };
            Employee employee1 = new Employee()
            {
                Id = 2,
                Name = "Seymur",
                Salary = 350
            };
            Department department = new Department()
            {
                Id = 1,
                Name = "Code Academy",
                
            };
            department.Employees.Add(employee);
            department.Employees.Add(employee1);
            string path1 = @"C:\Users\tu7mxp4w4\source\repos\ConsoleApp32\ConsoleApp1\Files\";

            string employeJsonStr = JsonConvert.SerializeObject(department);

            //using (StreamWriter streamWriter = new StreamWriter(path1 + @"Database.json"))
            //{
            //    streamWriter.Write(employeJsonStr);
            //}
            //using (StreamReader streamR = new StreamReader(path1 + @"Database.json"))
            //{
            //    Console.WriteLine(streamR.ReadToEnd());
            //}
            Department department1 = JsonConvert.DeserializeObject<Department>(employeJsonStr);
            foreach (var employee2 in department.Employees)
            {
                if (employee2.Id == 1)
                {
                    employee.ShowInfo();
                }

            }
            string Choice -Console.ReadLine()
            bool ischek = true;
            do
            {
                sw




            } while (ischek);


        }
    }
}
