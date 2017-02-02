using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {    
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= 5 && value >= 1)
                {
                    floor = value;
                }
                else if (value > 5)
                {
                    Console.WriteLine("You fucking reject there are only 5 floors lmAO lol,,");

                }
                else if (value < 1)
                {
                    Console.WriteLine("Trying to go UG? not gonna happen my man LOL");
                }
            }
        }
    }
    
}
