using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Sv-0908-917", "Savings");
            account1.Deposit(2000);
            account1.Deposit(4500);
            account1.Withdraw(3000);

            AccountHolder accountHolder = new AccountHolder();
            accountHolder.Name = "Latif";
            accountHolder.Email = "latif@mail.com";
            accountHolder.AnAccount = account1;

            accountHolder.AnAccount.Deposit(5000);
            accountHolder.AnAccount.Withdraw(1500);
            
            Console.WriteLine(accountHolder.Name);
            Console.WriteLine(accountHolder.Email);
            Console.WriteLine(accountHolder.AnAccount.Number);
            Console.WriteLine(accountHolder.AnAccount.Balance);

            Console.ReadKey();
        }
    }
}
