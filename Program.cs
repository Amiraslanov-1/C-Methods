using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {

            Hotel hotels = new Hotel("Salam");
            Hotel hotels1 = new Hotel("Salam");
            Hotel hotels2 = new Hotel("Salam");

            Room room = new Room()
            {
                Name = "Salam",
                Price = 5,
                PersonCapacity = 3
            };
            hotels.AddRoom(room);

            try
            {
                hotels.MakeResevation(1);
            }
            catch (NotAvaibleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(hotels[0].IsAvailable);




        }






    }



  
}
