﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselApplication
{
    class Bike : Vessel
    {
        public bool Gear { get; set; }
        public string GearName { get; set; }
        public override string ToString()
        {
            return base.ToString() + " Gear: " + Gear + " Possible gear name: " + GearName;                            
        }
    }
}
