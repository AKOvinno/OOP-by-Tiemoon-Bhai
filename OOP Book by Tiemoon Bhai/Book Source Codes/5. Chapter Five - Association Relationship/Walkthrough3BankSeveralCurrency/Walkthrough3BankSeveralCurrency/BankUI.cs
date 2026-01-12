using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkthrough3BankSeveralCurrency
{
    public partial class BankUI : Form
    {
        BankAccount anAccount = new BankAccount();
        public BankUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount.AccountNo = accountNoEntryTextBox.Text;
            anAccount.AccountType = typeComboBox.Text;
            Customer aCustomer = new Customer();
            aCustomer.Name = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;
            anAccount.AccountCustomer = aCustomer;
            MessageBox.Show("Account has been created.");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Deposit(amount);
            MessageBox.Show("Deposited");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameShowTextBox.Text = anAccount.AccountCustomer.Name;
            emailShowTextBox.Text = anAccount.AccountCustomer.Email;
            accountNoShowTextBox.Text = anAccount.AccountNo;
            typeShowTextBox.Text = anAccount.AccountType;
            balanceInBDTTextBox.Text = anAccount.BalanceInBDT.ToString();
        }
    }
}
