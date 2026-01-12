using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] salaries = new[] {25000.50, 45050.75, 24900, 56000};
            double totalSalary = 0;

            foreach (double salaryAmount in salaries)
            {
                totalSalary += salaryAmount;
            }

            //for (int i = 0; i < salaries.Length; i++)
            //{
            //    totalSalary += salaries[i];
            //}

            Console.WriteLine("Total Salary Amount: " + totalSalary);
            Console.WriteLine("Average Salary: " + (totalSalary/4));

            Console.ReadLine();
        }
    }
}
