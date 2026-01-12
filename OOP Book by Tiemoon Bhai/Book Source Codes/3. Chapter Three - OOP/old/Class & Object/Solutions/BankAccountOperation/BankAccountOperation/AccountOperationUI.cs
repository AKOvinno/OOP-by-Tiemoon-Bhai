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
                userMessage = myAccount.customerName + ", your account number: " + myAccount.accountNumber +
                              " and it's balance: " + myAccount.balance;
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
            myAccount.accountNumber = accountNumberTextBox.Text;
            myAccount.customerName = customerNameTextBox.Text;
            userMessage = "Account has been created.\nAccount number: " + myAccount.accountNumber + "\nCustomer name: " +
                                myAccount.customerName;
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
