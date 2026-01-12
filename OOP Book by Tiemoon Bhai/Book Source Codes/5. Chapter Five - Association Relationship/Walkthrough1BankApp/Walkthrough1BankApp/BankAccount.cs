using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1BankApp
{
class BankAccount
{
        public string AccountNo { set; get; }
        public string AccountType { set; get; }
        public double Balance { private set; get; }

        public Customer AccountCustomer { set; get; }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

    }
}
