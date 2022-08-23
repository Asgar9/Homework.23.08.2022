using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hotel.Models
{
    class Hotel
    {
        public string Name;
        private Room[] _rooms;
        ArrayList rooms = new ArrayList();
        public string AddRoom()
        {

            return null;
        }


        public Hotel(string Name)
        {
            this.Name = Name;
        }
        public bool Reserve(int? roomId)
        {
            return false;
        }
        //NotAvaibleException:Exception
        //    {
        //          }
        
       
    }
}
