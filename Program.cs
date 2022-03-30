
using System;
using System.Reflection;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Akif", "Hesenli", 70);
            Student student2 = new Student("Allahverdi", "Ehmedov", 55);
            Group group = new Group();
            group.StudentLimit = 5;
            group.AddStudent(student1);
            group.AddStudent(student2);


            Assembly assembly = Assembly.GetExecutingAssembly();
            var groupType = typeof(Group);


            foreach (var type in assembly.GetTypes())
            {
                if (type == groupType)
                {
                    int sum = 0;
                    foreach (var item in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        
                        if (typeof(Student[]) == item.GetValue(group).GetType())
                        {
                            Student[] students = (Student[])item.GetValue(group);
                            foreach (var stu in students)
                            {
                                sum += stu.Point;
                            }

                        }
                        //if(item.GetValue(group) == )
                        //{
                        //    Console.WriteLine("ok");
                        //}
                        //Student[] students = item.GetValue(group) as Student[];
                        //Console.WriteLine(item.GetValue(group));
                        //if (item.GetValue(group) is Student[])
                        //{
                        //    students = (Student[])item.GetValue(group);
                        //}
                        //foreach (var stu in students)
                        //{
                        //    Console.WriteLine(stu);
                        //}
                    }

                Console.WriteLine(sum);
                }
            }

        }




    }
}
