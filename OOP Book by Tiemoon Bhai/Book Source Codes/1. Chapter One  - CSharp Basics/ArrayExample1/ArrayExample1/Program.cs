using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            numbers[0] = 12;
            numbers[1] = 100;
            numbers[2] = 34;

            //numbers[12] = 100;

            int aNumber = numbers[0];
            Console.WriteLine(aNumber);

            aNumber = numbers[1];
            Console.WriteLine(aNumber);

            aNumber = numbers[2];
            Console.WriteLine(aNumber);

            


            Console.ReadKey();

        }
    }
}
