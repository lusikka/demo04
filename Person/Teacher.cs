using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to teacher!!!");
        }
        public override string ToString()
        {
            // base on tässä tapauksessa Person-luokka
            // "eli" kutsutaan Person-luokan ToString()-metodia
            return base.ToString() + " " + Room;
        }
    }
}
