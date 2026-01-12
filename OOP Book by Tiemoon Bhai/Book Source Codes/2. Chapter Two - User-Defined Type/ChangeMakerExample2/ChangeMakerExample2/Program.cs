using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMakerExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Nahid";
            st1.cGPA = 2.75;
            Console.WriteLine("Before: " + st1.name + " " + st1.cGPA + " " + st1.ageInYear);
            ChangeTheStudent(st1);
            Console.WriteLine("After: " + st1.name + " " + st1.cGPA + " " + st1.ageInYear);
            Console.ReadKey();
        }
        public static void ChangeTheStudent(Student aStudent)
        {
            aStudent.name = "Latif";
            aStudent.cGPA = 3.0;
            aStudent.ageInYear = 20;
        }
    }
}
