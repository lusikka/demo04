using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            amp.Volume = 10;
            do
            {
                Console.WriteLine("The amplifier volume is currently set to " + amp.Volume);
                Console.WriteLine("Set it to something else, will ya?");
                string line = Console.ReadLine();
                amp.Volume = int.Parse(line);
            } while (true);

        }
    }
}
