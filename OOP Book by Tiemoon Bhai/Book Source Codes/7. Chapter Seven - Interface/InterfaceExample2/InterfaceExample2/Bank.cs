using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class Bank
    {
        public string Name { set; get; }
        public List<IBankAccount> bankAccounts { set; get; }
        public Bank()
        {
            bankAccounts = new List<IBankAccount>();
        }

        public void AddAccount(IBankAccount anAccount)
        {
            bankAccounts.Add(anAccount);
        }



    }
}
