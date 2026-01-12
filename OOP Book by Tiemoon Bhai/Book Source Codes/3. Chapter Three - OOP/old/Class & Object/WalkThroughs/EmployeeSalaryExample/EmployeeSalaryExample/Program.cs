using System;

namespace EmployeeSalaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary salary1 = new Salary();
            salary1.basicAmount = 25000;
            salary1.houseRentPercentage = 30;
            salary1.medicalAllowancePercentage = 10;
            double total = salary1.GetTotal();

            Console.WriteLine("Total Salary: " + total);
            Console.ReadKey();
        }
    }
}
