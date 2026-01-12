using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.id = "emp-212";
            employee1.name = "Dolon";
            employee1.salaryAmount = 30000;

            Employee employee2 = new Employee();
            employee2.id = "emp-100";
            employee2.name = "Salam";
            employee2.salaryAmount = 45000;
        }
    }
}
