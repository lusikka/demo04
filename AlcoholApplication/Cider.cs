using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholApplication
{
    class Cider : Alcohol
    {
        public string CiderType;
        public override string ToString()
        {
            return base.ToString() + " ~ " + CiderType;
        }
    }
}
