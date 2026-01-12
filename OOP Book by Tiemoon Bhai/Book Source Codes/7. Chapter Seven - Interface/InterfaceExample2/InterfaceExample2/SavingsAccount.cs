using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class SavingsAccount : IBankAccount
    {
        public string AccountNo {set;get;}
        public double Balance { private set; get; }
        public double InterestAmount { set; get; }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void CalcuateInterest()
        { 
            //TODO
        }
}
}
