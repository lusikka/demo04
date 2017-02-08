using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonT3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public void CheckStatus()
        {
            Console.WriteLine("Name: " + Name + "Profession: " + Profession + "Salary: " + Salary);
        }
        public override string ToString()
        {
            return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}
