using System;
using System.Windows.Forms;

namespace EmployeeInformationPrimitiveType
{
    public partial class EmployeeInformationUI : Form
    {
        private string id;
        private string name;
        private double salary;

        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private void saveAndClearButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            name = nameTextBox.Text;
            salary = Convert.ToDouble(salaryTextBox.Text);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }
        private void showSavedDataButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = id;
            nameTextBox.Text = name;
            salaryTextBox.Text = salary.ToString();
        }
    }
}
