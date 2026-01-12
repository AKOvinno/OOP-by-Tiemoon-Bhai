
namespace EmployeeSalaryExample
{
    class Salary
    {
        public double basicAmount;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double GetTotal()
        {
            return basicAmount +
                GetHouseRentAmount() + 
                GetMedicalAmount();
        }

        public double GetHouseRentAmount()
        {
            return (houseRentPercentage*basicAmount)/100;
        }

        public double GetMedicalAmount()
        {
            return (medicalAllowancePercentage*basicAmount)/100;
        }
    }
}
