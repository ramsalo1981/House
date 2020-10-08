using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Apartment : Residence
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }

        public Apartment()
        {

        }
        public Apartment(string address, int livingArea, int monthlyCost, int floor, bool hasElevator) : base(address, livingArea, monthlyCost)
        {
            Floor = floor;
            HasElevator = hasElevator;
        }
       
    }
}
