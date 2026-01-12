using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    internal class BankAccount
    {
        public string accountNumber;
        public string accountHolderName;
        public double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
