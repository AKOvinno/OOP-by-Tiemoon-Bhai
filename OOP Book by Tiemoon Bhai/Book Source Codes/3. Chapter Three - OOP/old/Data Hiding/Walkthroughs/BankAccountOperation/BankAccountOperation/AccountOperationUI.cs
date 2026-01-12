using System;
using System.Windows.Forms;

namespace BankAccountOperation
{
    public partial class AccountOperationUI : Form
    {
        private Account myAccount = null;
        private double amount = 0;
        private string userMessage = "";

        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (myAccount != null)
            {
                userMessage = myAccount.GetCustomerName() + ", your account number: " + myAccount.GetAccountNumber() +
                              " and it's balance: " + myAccount.GetBalance();
            }
            else
            {
                userMessage = "Account is not created.";
            }
            MessageBox.Show(userMessage);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            myAccount = new Account();
            myAccount.SetAccountNumber(accountNumberTextBox.Text);
            myAccount.SetCustomerName(customerNameTextBox.Text);
            userMessage = "Account has been created.\nAccount number: " + myAccount.GetAccountNumber() + "\nCustomer name: " +
                                myAccount.GetCustomerName();
            MessageBox.Show(userMessage);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            userMessage = myAccount.Deposit(amount);
            MessageBox.Show(userMessage);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            userMessage = myAccount.Withdraw(amount);
            MessageBox.Show(userMessage);

        }
    }
}
