using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeRefTypeExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = a;
            a = 300;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();




        }
    }
}
