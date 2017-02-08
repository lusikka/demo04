using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Power = false;           
            int choice = 0;
            while (true)
            {
                Console.WriteLine("Welcome to Late's radio program. What would you like to do today?");
                if (radio.Power == false)
                {
                    Console.WriteLine("1. Turn on the radio");
                }
                else
                {
                    Console.WriteLine("1. Turn off the radio");
                }
                Console.WriteLine("2. Set the volume level");
                Console.WriteLine("3. Change the channel");
                Console.WriteLine("4. Check radio status");
                string line = Console.ReadLine();
                choice = int.Parse(line);
                if (choice == 1)
                {
                    if (radio.Power == false)
                    {
                        radio.Power = true;
                        radio.Volume = 2;
                        radio.Channel = 2000;
                    }
                    else if (radio.Power == true)
                    {
                        radio.Power = false;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please set the new volume level:");
                    string line1 = Console.ReadLine();
                    radio.Volume = int.Parse(line1);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Please set the new channel frequency (2000 - 20000):");
                    string line2 = Console.ReadLine();
                    radio.Channel = int.Parse(line2);
                }
                else if (choice == 4)
                {
                    radio.RadStatus();
                }
                else
                    Console.WriteLine("Not a valid number.");


            }
        }
    }
}
