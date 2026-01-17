using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastBankSolution
{
    public partial class FastBankSolutionUI : Form
    {
        public FastBankSolutionUI()
        {
            InitializeComponent();
        }
        BankAccount anAccount = new BankAccount();
        private void FastBankSolutionUI_Load(object sender, EventArgs e)
        {
            TypeEntryComboBox.Items.Add("Regular");
            TypeEntryComboBox.Items.Add("Savings");
            TypeEntryComboBox.Items.Add("Salary");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            anAccount.AccountNo = AccountNumberEntryTextBox.Text;
            anAccount.AccountType = TypeEntryComboBox.Text;
            Customer aCustomer = new Customer();
            aCustomer.Name = CustomerNameEntryTextBox.Text;
            aCustomer.Email = EmailEntryTextBox.Text;
            anAccount.AccountCustomer = aCustomer;
            MessageBox.Show("Account has been created.");
        }

        private void TypeEntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aType = TypeEntryComboBox.SelectedItem.ToString();
            MessageBox.Show(aType + " Selected");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            anAccount.Deposit(Convert.ToDouble(AmountEntryTextBox.Text));
            MessageBox.Show("Amount has been deposited.");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double TempAmount = Convert.ToDouble(AmountEntryTextBox.Text);
            if (TempAmount > anAccount.BalanceInBDT) MessageBox.Show("Not Enough Balance.");
            else
            {
                anAccount.Withdraw(TempAmount);
                MessageBox.Show("Amount has been withdrawed.");
            }
        }
        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            CustomerNameShowTextBox.Text = anAccount.AccountCustomer.Name;
            EmailShowTextBox.Text = anAccount.AccountCustomer.Email;
            AccountNoShowTextBox.Text = anAccount.AccountNo;
            TypeShowTextBox.Text = anAccount.AccountType;
            BalanceInBDTShowTextBox.Text = anAccount.BalanceInBDT.ToString();
            BalanceInUSDShowTextBox.Text = anAccount.GetBalanceInUSD().ToString();
        }
    }
}
