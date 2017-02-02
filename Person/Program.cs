using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Erkki";
            teacher.LastName = "Esimerkki";
            teacher.Age = 69;
            teacher.Address = "Piippukatu 69";
            teacher.PhoneNumber = "696969696969";
            teacher.Room = "D696";
            Console.WriteLine(teacher.ToString());
            Student student = new Student("Zygmaloid", "Spencer", "K1337");
            student.Address = "Rauskurinne 1";
            student.Age = 12;
            student.PhoneNumber = "85854848458";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();

            student.StudentMethod();


        }
    }
}
