using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    public interface IBankAccount
    {
        string AccountNo { set; get; }
        double Balance { get; }
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
