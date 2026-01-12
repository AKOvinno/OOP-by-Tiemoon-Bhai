using System;
using System.Windows.Forms;

namespace PersonExampleInWindowsForm
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person personObject = new Person();
            personObject.firstName = firstNameTextBox.Text;
            personObject.middleName = middleNameTextBox.Text;
            personObject.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text = personObject.GetMyFullName();
            reverseNameTextBox.Text = personObject.GetMyReverseName();
        }
    }
}
