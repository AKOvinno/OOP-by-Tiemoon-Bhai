using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkThrough8EmployeeList
{
    public partial class EmployeeListUI : Form
    {
        List<Employee> employeeList = new List<Employee>();
        public EmployeeListUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee(nameTextBox.Text,
                emailTextBox.Text, contactNoTextBox.Text);
            employeeList.Add(anEmployee);
            MessageBox.Show("Employee Info. has been saved.");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = "";
            foreach (Employee anEmployee in employeeList)
            {
                string info = anEmployee.Name + " "
                    + anEmployee.Email + " "
                    + anEmployee.ContactNo + "\n";
                allInfo += info;
            }
            MessageBox.Show(allInfo);
        }


    }
}
