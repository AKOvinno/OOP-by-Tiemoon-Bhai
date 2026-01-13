using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeList
{
    public partial class EmployeeListUI : Form
    {
        List<Employee> employeeList = new List<Employee>();
        public EmployeeListUI()
        {
            InitializeComponent();
        }

        private void EmployeeListUI_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee(NameTextBox.Text, EmailTextBox.Text, ContactNoTextBox.Text);
            employeeList.Add(anEmployee);
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            ContactNoTextBox.Text = "";
            MessageBox.Show("Employee Info. has been saved.");
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = "";
            foreach (Employee anEmployee in employeeList)
            {
                string info = anEmployee.Name + " " + anEmployee.Email + " " + anEmployee.ContactNo + "\n";
                allInfo += info;
            }
            MessageBox.Show(allInfo);
        }
    }
}
