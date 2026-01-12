using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class BankAccountUI : Form
    {
        BankAccount anAccount;
        public BankAccountUI()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            anAccount = new BankAccount();
            anAccount.accountNumber = AccountNumberTextBox.Text;
            anAccount.accountHolderName = AccountHolderNameTextBox.Text;
            MessageBox.Show("Account has been created.");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            anAccount.Deposit(amount);
            MessageBox.Show(amount + " taka has been deposited.");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            anAccount.Withdraw(amount);
            MessageBox.Show(amount + " taka has been withdrawn.");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string info = anAccount.accountHolderName + "\n" + "Account number: " + anAccount.accountNumber + "\n" + "Balance: " + anAccount.balance;
            MessageBox.Show(info);
        }
    }
}
