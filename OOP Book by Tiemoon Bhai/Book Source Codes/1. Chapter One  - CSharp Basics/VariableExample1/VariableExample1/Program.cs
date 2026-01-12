using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sahel";
            string lastName = "Rana";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
