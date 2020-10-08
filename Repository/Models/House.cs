using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class House : Residence
    {
        public int Floors { get; set; }
        public int PlotArea { get; set; }

        public House(string address, int livingArea, int monthlyCost, int floors, int plotArea) : base(address, livingArea, monthlyCost)
        {
            Floors = floors;
            PlotArea = plotArea;
        }
    }
}
