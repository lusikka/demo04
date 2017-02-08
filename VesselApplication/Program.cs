using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            bike1.Name = "Mummon panssarivaunu";
            bike1.Color = "Red";
            bike1.Model = "Megapyörä 69";
            bike1.Year = 1969;
            bike1.Gear = true;
            bike1.GearName = "Paskavaihde12";
            Bike bike2 = new Bike();
            bike2.Name = "Driftaaja";
            bike2.Color = "Blue";
            bike2.Model = "Driftmaster 69";
            bike2.Year = 1569;
            bike2.Gear = true;
            Boat boat1 = new Boat();
            boat1.Name = "Jävla Boatriddar 666";
            boat1.Color = "Green";
            boat1.Model = "Ultravene 69";
            boat1.Year = 2020;
            boat1.BoatType = "Motorboat";
            boat1.SeatSum = 10;
            Boat boat2= new Boat();
            boat2.Name = "Karin paistopaatti";
            boat2.Color = "Electric Blue";
            boat2.Model = "KariNiemen veneet inc";
            boat2.Year = 2000;
            boat2.BoatType = "Kariboat";
            boat2.SeatSum = 100;
            Console.WriteLine("- Bike 1 -");
            Console.WriteLine(bike1.ToString());
            Console.WriteLine("- Bike 2 -");
            Console.WriteLine(bike2.ToString());
            Console.WriteLine("- Boat 1 -");
            Console.WriteLine(boat1.ToString());
            Console.WriteLine("- Boat 2 -");
            Console.WriteLine(boat2.ToString());
        }
    }
}
