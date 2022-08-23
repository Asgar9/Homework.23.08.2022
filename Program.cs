using hotel.Models;
using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Room lux = new Room("luxvilla",200,2);
            Console.WriteLine(lux.Id);
        }
    }
}
