using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 1;
            do
            {
                Console.WriteLine("We are currently in floor " + elevator.Floor);
                Console.WriteLine("Where would you like to go my boy?");
                string line = Console.ReadLine();
                elevator.Floor = int.Parse(line);
            } while (true);

        }
    }
}
