using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class EmployeeSalaryManagementUI : Form
    {
        Employee anEmployee = new Employee();
        public EmployeeSalaryManagementUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            anEmployee.Name = NameEntryTextBox.Text;
            anEmployee.Email = EmailEntryTextBox.Text;
            anEmployee.Id = IdEntryTextBox.Text;
            Salary aSalary = new Salary();
            aSalary.Basic = Convert.ToDouble(BasicEntryTextBox.Text);
            aSalary.ConveyancePercentage = Convert.ToDouble(ConveyancePercentageEntryTextBox.Text);
            aSalary.MedicalPercentage = Convert.ToDouble(MedicalPercentageEntryTextBox.Text);
            anEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("Information have been saved.");
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            IdShowTextBox.Text = anEmployee.Id;
            NameShowTextBox.Text = anEmployee.Name;
            EmailShowTextBox.Text = anEmployee.Email;
            BasicShowTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
            MedicalAmountShowTextBox.Text = anEmployee.EmployeeSalary.MedicalAmount().ToString();
            ConveyanceAmountShowTextBox.Text = anEmployee.EmployeeSalary.ConveyanceAmount().ToString();
            TotalShowTextBox.Text = anEmployee.EmployeeSalary.TotalSalary().ToString();
        }
    }
}
