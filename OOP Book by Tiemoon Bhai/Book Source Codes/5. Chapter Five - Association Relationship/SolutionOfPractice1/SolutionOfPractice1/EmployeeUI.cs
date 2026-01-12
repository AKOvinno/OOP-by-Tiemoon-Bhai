using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfPractice1
{
    public partial class EmployeeUI : Form
    {
        Employee anEmployee;

        public EmployeeUI()
        {
            anEmployee = new Employee();
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee.Id = idEntryTextBox.Text;
            anEmployee.Name = nameEntryTextBox.Text;
            anEmployee.Email = emailEntryTextBox.Text;
            Salary aSalary = new Salary();

            double basic = Convert.ToDouble(basicEntryTextBox.Text);
            double convPercent = Convert.ToDouble(convEntryTextBox.Text);
            double medicalPercent = Convert.ToDouble(medicalPercentEntryTextBox.Text);

            aSalary.Basic = basic;
            aSalary.ConveyancePercent = convPercent;
            aSalary.MedicalPercent = medicalPercent;
            anEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("Information has been saved.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            idShowTextBox.Text = anEmployee.Id;
            nameShowTextBox.Text = anEmployee.Name;
            emailShowTextBox.Text = anEmployee.Email;
            basicShowTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
            convAmountShowTextBox.Text = anEmployee.EmployeeSalary.GetConveyanceAmount().ToString();
            medicalAmountShowTextBox.Text = anEmployee.EmployeeSalary.GetMedicalAmount().ToString();
            totalShowTextBox.Text = anEmployee.EmployeeSalary.GetTotal().ToString();
        }
    }
}
