using System;
using System.Windows.Forms;
using FastBankAccountApp.Objects;

namespace FastBankAccountApp
{
    public partial class BankUI : Form
    {
        private AccountHolder anAccountHolder;
        private double amount;

        public BankUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccountHolder = new AccountHolder();
            anAccountHolder.Name = customerNameEntryTextBox.Text;
            anAccountHolder.Email = emailEntryTextBox.Text;
            Account anAccount = new Account();
            anAccount.Number = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = openingDateEntryTextBox.Text;
            anAccountHolder.AnAccount = anAccount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            string msg = anAccountHolder.AnAccount.Deposit(amount);
            MessageBox.Show(msg);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            string msg = anAccountHolder.AnAccount.Withdraw(amount);
            MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = anAccountHolder.Name;
            emailDisplayTextBox.Text = anAccountHolder.Email;
            openingDateDisplayTextBox.Text = anAccountHolder.AnAccount.OpeningDate;
            accountNumberDisplayTextBox.Text = anAccountHolder.AnAccount.Number;
            balanceTextBox.Text = anAccountHolder.AnAccount.Balance.ToString();
        }


    }
}
