using System;

namespace BankAccountOperation
{
    public class Account
    {
        private string accountNumber;
        private string customerName;
        private double balance;

        public void SetAccountNumber(string accountNumber)
        {
            if (accountNumber.Length == 12)
            {
                this.accountNumber = accountNumber;
            }
            else
            {
                throw new ApplicationException("Account number must be ten character long");
            }
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public double GetBalance()
        {
            return balance;
        }

        public string Deposit(double amount)
        {
            balance += amount;
            return amount + " taka has been deposited."; 
        }

        public string Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return amount + " taka has been withdrawn.";

            }
            else
            {
                return "No sufficient balance;";
            }
        }
    }
}
