using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Slater Koekkoek";
            employee1.Profession = "Headline Writer";
            employee1.Salary = 2048;           
            Boss boss = new Boss();
            boss.Name = "Mr. Satan";
            boss.Profession = "The Devil";
            boss.Salary = 6666;
            boss.Car = "Dodge Hellcat";
            boss.Bonus = 666;
            Console.WriteLine(employee1.ToString());
            Console.WriteLine(boss.ToString());
            employee1.Name = "Darius Kasparaitis";
            employee1.Profession = "Professional Failure";
            employee1.Salary = 6969;
            Console.WriteLine(employee1.ToString());

        }
    }
}
