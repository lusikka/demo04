using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Amp
    {
        private readonly int maxVol = 100;
        private readonly int minVol = 0;
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Volume can't go to the negatives. You seriously didn't figure that out, huh");
                    Console.WriteLine("We'll just set it to 0, don't worry.");
                    volume = minVol;
                }
                else if (value > 100)
                {
                    Console.WriteLine("I'm afraid the maximum volume is 100.");
                    Console.WriteLine("We'll just set it to 100, don't worry.");
                    volume = maxVol;
                }

            }

        }
    }
}
