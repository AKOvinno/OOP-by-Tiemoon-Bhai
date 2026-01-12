using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter obtained score in physics: ");
            string userInput = Console.ReadLine();
            double physicsScore = Convert.ToDouble(userInput);

            if (physicsScore > 100 || physicsScore < 0)
            {
                Console.WriteLine("Your entered score is invalid. Check it and try again");
                Console.ReadKey();
                return;
            }


            if (physicsScore <= 100 && physicsScore >= 90)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else if (physicsScore < 90 && physicsScore >= 80)
            {
                Console.WriteLine("Your Grade is B+ ");
            }
            else if (physicsScore < 80 && physicsScore >= 70)
            {
                Console.WriteLine("Your Grade is C+");
            }
            else
            {
                Console.WriteLine("Your Grade is F");
            }
            Console.ReadKey();
        }
    }
}
