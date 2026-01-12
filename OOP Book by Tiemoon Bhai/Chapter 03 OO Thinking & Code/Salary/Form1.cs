using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class SalaryCalculatorUI : Form
    {
        Employee aEmployee;
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void SalaryCalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void ShowTotalButton_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aEmployee.EmployeeName = EmployeeNameTextBox.Text;
            aEmployee.EmployeeBasicSalary = Convert.ToDouble(BasicAmountTextBox.Text);
            aEmployee.HouseRent = Convert.ToDouble(HouseRentTextBox.Text);
            aEmployee.MedicalAllowance = Convert.ToDouble(MedicalAllowanceTextBox.Text);

            aEmployee.HouseRent = aEmployee.EmployeeBasicSalary * (aEmployee.HouseRent / 100);
            aEmployee.MedicalAllowance = aEmployee.EmployeeBasicSalary * (aEmployee.MedicalAllowance / 100);

            MessageBox.Show(aEmployee.EmployeeName + ", your total salary is: " + aEmployee.TotalSalary());

        }
    }
}
