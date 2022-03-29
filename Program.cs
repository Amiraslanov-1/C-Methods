using System;


namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssss");
            string pass = Console.ReadLine();

            while (!User.CheckPassword(pass))
            {
                Console.WriteLine("wwwwww");
                pass = Console.ReadLine();
            }
           





        }
   
    }
}
