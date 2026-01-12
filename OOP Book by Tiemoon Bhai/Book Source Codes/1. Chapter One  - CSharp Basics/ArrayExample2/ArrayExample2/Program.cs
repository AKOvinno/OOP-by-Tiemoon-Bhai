using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**This program shows only even numbers of your number list**");
            Console.WriteLine("How many number will you enter:");
            int arraySize = Convert.ToInt16(Console.ReadLine());

            int[] allNumber = new int[arraySize];

            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine("Enter number " + (index + 1));
                int aNumber = Convert.ToInt16(Console.ReadLine());
                allNumber[index] = aNumber;
            }

            Console.WriteLine("Here even numbers are:");
            for (int index = 0; index < arraySize; index++)
            {
                int aNumber = allNumber[index];
                if (aNumber%2 == 0)
                {
                    Console.Write(aNumber + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
