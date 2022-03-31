using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Room
    {
        static int _id;
        public int Id { get; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int PersonCapacity { get; set; }

        



        public bool IsAvailable = true;
        public Room(string name,double price,int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public Room()
        {
        }

        public string ShowInfo()
        {
            return$"Price :{Price} Name : {Name}   PersonCapacity : {PersonCapacity}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
