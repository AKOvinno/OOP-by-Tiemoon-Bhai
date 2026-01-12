using System.Windows.Forms;
using System;

namespace EmployeeSalaryApp
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showMeSalaryButton_Click(object sender, System.EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show(aSalary.employeeName + " your total salary is: " + aSalary.GetTotalSalary())
            ;
        }
    }
}
