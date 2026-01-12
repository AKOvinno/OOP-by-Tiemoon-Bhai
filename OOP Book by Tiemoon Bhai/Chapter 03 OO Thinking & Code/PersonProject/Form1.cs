using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonProject
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }

        private void PersonUI_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text = aPerson.GetMyFullName();
            reverseNameTextBox.Text = aPerson.GetFullReverseName();
        }
    }
}
