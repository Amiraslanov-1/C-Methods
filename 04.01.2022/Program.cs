
using System;

namespace DataStructure
{
    class Program
    {
     

        static void Main(string[] args)
        {

            User user = new User();
         

            
            bool isCheck = false;
            do
            {
                Console.WriteLine("1.Share status");
                Console.WriteLine("2.Get status ");
                Console.WriteLine("3.Quit");
                string Choise = Console.ReadLine();

                switch (Choise)
                {

                    case "1":
                        Console.WriteLine("Title Daxil Edin :");
                        string title = Console.ReadLine();
                        Console.WriteLine("Content Daxil Edin :");
                        string content = Console.ReadLine();
                        Status status = new Status(title, content);
                        user.ShareStatus(status);
                    break;
                    case "2":
                        Console.WriteLine("Title Daxil Edin :");
                        string title1 = Console.ReadLine();
                        Console.WriteLine(user.GetStatusByTitle(title1)); 
                        break;
                    case "3":
                        isCheck = true;
                        Console.WriteLine("Program Sona Chatdi !!!");
                        break;
                    default:
                        break;
                }

            } while (!isCheck);


        }

      
    }
}
