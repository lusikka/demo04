using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholApplication
{
    class Alcohol
    {
        public double Vol { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return " Price: " + Price + " euro" + ", Vol: " + Vol; 
        }
    }
}
