using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        private readonly int maxVol = 9;
        private readonly int minVol = 0;
        private int volume;
        private readonly double minChan = 2000.00;
        private readonly double maxChan = 20000.00;
        private double chan;
        private bool power;
        public void RadStatus()
        {
            if (Power == false)
            {
                Console.WriteLine("The radio is powered off.");
            }
            else
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Radio Status: ");
                Console.WriteLine("Volume: " + Volume);
                Console.WriteLine("Current Channel: " + Channel);
                Console.WriteLine("-----------------------------------");
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (Power == false)
                {
                    Console.WriteLine("The radio is currenty powered off. You may want to consider turning it on first.");
                }
                else
                { 
                    if (value >= 0 && value <= 9)
                    {
                        volume = value;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("Volume can't be lower than zero, you dummy.");
                        Console.WriteLine("We'll just set it to zero for now.");
                        volume = minVol;
                    }
                    else if (value > 9)
                    {
                        Console.WriteLine("Volume can't be higher than 9");
                        Console.WriteLine("We'll just set it to the max for now.");
                        volume = maxVol;
                    }
                }
            }
        }
                 
        public bool Power { get; set; }
           
        public double Channel {
            get
            {
                return chan;
            }
                
            set
            {
                if (Power == false)
                {
                    Console.WriteLine("The radio is currenty powered off. You may want to consider turning it on first.");
                }
                else
                { 
                    if (value >= 2000 && value <= 20000)
                    {
                        chan = value;
                    }
                    else if (value < 2000)
                    {
                        Console.WriteLine("Unfortunately, 2000 is the lowest we can go.");
                        Console.WriteLine("As punishment for your mistake, we are defaulting you to the worst station.");
                        Channel = 6969;
                    }
                    else if (value > 20000)
                    {
                        Console.WriteLine("Unfortunately, 20000 is the highest we can go.");
                        Console.WriteLine("As punishment for your mistake, we are defaulting you to the worst station.");
                        Channel = 6969;
                    }
                }
            }
         }

    }
}
