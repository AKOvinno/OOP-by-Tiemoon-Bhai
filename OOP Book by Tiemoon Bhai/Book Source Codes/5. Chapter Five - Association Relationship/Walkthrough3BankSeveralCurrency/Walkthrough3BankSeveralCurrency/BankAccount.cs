using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough3BankSeveralCurrency
{
    class BankAccount
    {
        public string AccountNo { set; get; }
        public string AccountType { set; get; }
        public double BalanceInBDT { private set; get; }

        public Customer AccountCustomer { set; get; }
        public void Deposit(double amount)
        {
            BalanceInBDT += amount;
        }

        public void Withdraw(double amount)
        {
            BalanceInBDT -= amount;
        }

        public double GetBalanceInUSD()
        {
            CurrencyConverter converter = new CurrencyConverter();
            return converter.ConvertToUSD(BalanceInBDT);
        }
    }
}
