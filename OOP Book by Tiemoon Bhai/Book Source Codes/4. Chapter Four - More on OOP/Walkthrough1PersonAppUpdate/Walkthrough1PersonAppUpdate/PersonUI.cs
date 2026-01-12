using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkthrough1PersonAppUpdate
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }


        //private void showButton_Click(object sender, EventArgs e)
        //{
        //    if (firstNameTextBox.Text.Length <2)
        //    {
        //        MessageBox.Show("First name must be minimum two-character long");
        //        return;
        //    }
        //    if (lastNameTextBox.Text.Length < 2)
        //    {
        //        MessageBox.Show("Last name must be minimum two-character long");
        //        return;            
        //    }
        //    Person aPerson = new Person();
        //    aPerson.firstName = firstNameTextBox.Text;
        //    aPerson.middleName = middleNameTextBox.Text;
        //    aPerson.lastName = lastNameTextBox.Text;

        //    fullNameTextBox.Text = aPerson.GetMyFullName();
        //    reverseNameTextBox.Text = aPerson.GetFullReverseName();
        //}

        private void showButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.SetFirstName(firstNameTextBox.Text);
            aPerson.SetMiddleName(middleNameTextBox.Text);
            aPerson.SetLastName(lastNameTextBox.Text);

            fullNameTextBox.Text = aPerson.GetMyFullName();
            reverseNameTextBox.Text = aPerson.GetFullReverseName();
        }
    }
}
