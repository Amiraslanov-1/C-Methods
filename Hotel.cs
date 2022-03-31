using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Hotel
    {
       




        public string Name { get; set; }

        List<Room> rooms = new List<Room>();



        public Room this[int i]
        {
            get => rooms[i];
            set
            {
                rooms[i] = value;
            }
        }
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void MakeResevation(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Nulldur");

            }
            foreach (Room room in rooms)
            {
                if (room.Id==id)
                {
                    Console.WriteLine(room);
                }
                else if(room.IsAvailable==false)
                {
                    throw new NotAvaibleException("yoxdur");
                }
                else if(room.IsAvailable==true)
                {
                    room.IsAvailable = false;
                }
            }
      


        }


    }
}
