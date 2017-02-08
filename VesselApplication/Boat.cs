﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselApplication
{
    class Boat : Vessel
    {
        public string BoatType { get; set; }
        public int SeatSum { get; set; }
        public override string ToString()
        {
            return base.ToString() + " Type of boat: " + BoatType + " Number of seats: " + SeatSum; 
        }
    }
}
