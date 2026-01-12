using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough2MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine(100);
            Console.WriteLine(10.90);
            Console.WriteLine(true);
            Console.WriteLine("Name = {0}, Email = {1}", "Rana", "r@mail.com");

            Calculator aCalculator = new Calculator();
            aCalculator.Add(12, 80.7);
            aCalculator.Add(100, 2, 45);
            
            Console.ReadLine();
        }
    }
}
