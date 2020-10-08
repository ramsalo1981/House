using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public abstract class Residence
    {
        public ObjectId Id { get; set; }
        public string Address { get; set; }
        public int LivingArea { get; set; }
        public int MonthlyCost { get; set; }

        public Residence(string address, int livingArea, int monthlyCost)
        {
            Address = address;
            LivingArea = livingArea;
            MonthlyCost = monthlyCost;
        }
        public Residence()
        {

        }

    }
}
