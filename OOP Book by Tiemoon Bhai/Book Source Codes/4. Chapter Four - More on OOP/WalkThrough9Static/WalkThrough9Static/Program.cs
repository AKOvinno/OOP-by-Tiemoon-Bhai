using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkThrough9Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            Student.NoOfStudents = 100;
            Student.NoOfStudents = 80;

            Console.WriteLine(Student.NoOfStudents);     
        }
    }
}
