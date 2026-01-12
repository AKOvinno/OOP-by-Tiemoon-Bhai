using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Result result1 = new Result();
            result1.studentRegNo = "2018-01-053";
            result1.mathScore = 92;
            result1.physicsScore = 85;
            result1.chemistryScore = 98;
            Console.WriteLine("Reg. No: " + result1.studentRegNo);
            Console.WriteLine("Average: " + result1.GetAverage());
            Console.WriteLine("Grade Letter: " + result1.GetGradeLetter());
            Console.WriteLine("-----------");

            Result result2 = new Result();
            result2.studentRegNo = "2018-01-011";
            result2.mathScore = 54;
            result2.physicsScore = 48;
            result2.chemistryScore = 34;
            Console.WriteLine("Reg. No: " + result2.studentRegNo);
            Console.WriteLine("Average: " + result2.GetAverage());
            Console.WriteLine("Grade Letter: " + result2.GetGradeLetter());
            Console.WriteLine("-----------");

            Result result3 = new Result();
            result3.studentRegNo = "2018-01-157";
            result3.mathScore = 87;
            result3.physicsScore = 76;
            result3.chemistryScore = 82;
            Console.WriteLine("Reg. No: " + result3.studentRegNo);
            Console.WriteLine("Average: " + result3.GetAverage());
            Console.WriteLine("Grade Letter: " + result3.GetGradeLetter());
            Console.ReadKey();
        }
    }
}
