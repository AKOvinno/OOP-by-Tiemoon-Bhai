using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> salary = new Dictionary<string, double>();
            salary.Add("emp-098", 25000);
            salary.Add("emp-012", 34000);
            salary.Add("emp-342", 11000);
            salary.Add("emp-111", 25000);

            //employeSalary.Add("emp-111", 23000);

            Console.WriteLine("Emplyee Code || Salary Amount");
            foreach (KeyValuePair<string, double> codeSalary in salary)
            {
                Console.WriteLine(codeSalary.Key + " || " + codeSalary.Value);
            }
            Console.ReadKey();
        }
    }
}
