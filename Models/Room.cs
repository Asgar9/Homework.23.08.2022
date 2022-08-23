using System;
using System.Collections.Generic;
using System.Text;

namespace hotel.Models
{
    class Room
    {
        public  int Id { get; }
     
        public string Name;
        public int Price;
        public int PersonCapacity { get; set; }
        public bool IsAvaible()
        {
            return true;
        }
        public string ShowInfo()
        {
            return null;
        }
        public Room(string Name,int Price,int PersonCapacity)
        {
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            Id++;

        }


        
    }
}
