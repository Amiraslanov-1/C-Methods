using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=35;
            Add(ref num);
            Console.WriteLine(num);

        }
        static int Add(int num)
        {
            int i=0;
            while (i*i<num)
            {
                i++;
            }
            num=i-1;
            return num;

        }
    }
}
