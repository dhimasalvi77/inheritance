using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dhimas", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Alvi", 30, "19112805", "networking");
            teacher.GetNameAndAge();

            Student student = new Student("Hidayah", 19, "2805", "dhimas.hidayah@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}