using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Employee
    {
        public string EmployeeName;
        public double EmployeeBasicSalary;
        public double HouseRent;
        public double MedicalAllowance;
        
        public double TotalSalary()
        {
            return EmployeeBasicSalary + HouseRent + MedicalAllowance;
        }
    }
}
