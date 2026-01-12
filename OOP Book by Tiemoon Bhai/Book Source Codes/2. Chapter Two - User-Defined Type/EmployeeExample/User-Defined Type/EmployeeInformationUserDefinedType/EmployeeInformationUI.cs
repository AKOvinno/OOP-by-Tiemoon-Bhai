using System;
using System.Windows.Forms;

namespace EmployeeInformationUserDefinedType
{
    public partial class EmployeeInformationUI : Form
    {
        Employee anEmployee = new Employee();
        public EmployeeInformationUI()
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
