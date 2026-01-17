using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManagement
{
    internal class Salary
    {
        public double Basic { set; get; }
        public double MedicalPercentage { set; get; }
        public double ConveyancePercentage { set; get; }
        public double MedicalAmount()
        {
            return (Basic * MedicalPercentage / 100);
        }
        public double ConveyanceAmount()
        {
            return (Basic * ConveyancePercentage / 100);
        }
        public double TotalSalary()
        {
            return Basic + MedicalAmount() + ConveyanceAmount();
        }
    }
}
