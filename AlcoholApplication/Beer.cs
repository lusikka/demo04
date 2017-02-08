using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholApplication
{
    class Beer : Alcohol
    {
        public string BeerType;
        public override string ToString()
        {
            return base.ToString() + " ~ " + BeerType;
        }
    }
}
