using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselApplication
{
    class Vessel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + " Color: " + Color + " Model Year: " + Year;
        }
    }
}
