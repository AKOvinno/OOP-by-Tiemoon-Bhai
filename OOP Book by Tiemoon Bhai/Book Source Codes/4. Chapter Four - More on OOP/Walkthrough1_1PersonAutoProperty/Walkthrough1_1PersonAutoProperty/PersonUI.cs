using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkthrough1_1PersonAutoProperty
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.FirstName = firstNameTextBox.Text;
            aPerson.MiddleName = middleNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;
            fullNameTextBox.Text = aPerson.GetFullReverseName();
            reverseNameTextBox.Text = aPerson.GetFullReverseName(); 
        }
    }
}
