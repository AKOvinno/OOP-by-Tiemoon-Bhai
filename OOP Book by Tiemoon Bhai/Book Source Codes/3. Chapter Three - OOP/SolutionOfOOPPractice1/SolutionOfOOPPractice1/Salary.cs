using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfOOPPractice1
{
    public class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double GetHouseRentAmount()
        {
            return (basicAmount / 100) * houseRentPercentage;
        }

        public double GetMedicalAllowanceAmount()
        {
            return (basicAmount / 100) * medicalAllowancePercentage;
        }

        public double GetTotalSalary()
        {
            return basicAmount + GetHouseRentAmount() + GetMedicalAllowanceAmount();
        }
    }
}
