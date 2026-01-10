using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedType
{
    public partial class Form1 : Form
    {
        Employee anEmployee = new Employee(); // How to make fields readonly?
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAndClearButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salaryAmount = Convert.ToDouble(salaryTextBox.Text);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void showSavedDataButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = anEmployee.salaryAmount.ToString();
        }

        private void isPunctualButton_Click(object sender, EventArgs e)
        {
            string info = anEmployee.GetInfoAboutEmployee();
            MessageBox.Show(info);
        }
    }
}
