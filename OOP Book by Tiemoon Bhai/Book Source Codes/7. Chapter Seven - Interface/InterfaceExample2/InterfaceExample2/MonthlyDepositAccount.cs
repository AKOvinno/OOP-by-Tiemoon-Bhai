using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class MonthlyDepositAccount :IBankAccount
    {
        public double monthlyDepositAmount;
        public 
    
public string AccountNo
{
	  get 
	{ 
		throw new NotImplementedException(); 
	}
	  set 
	{ 
		throw new NotImplementedException(); 
	}
}

public double Balance
{
	get { throw new NotImplementedException(); }
}

public void Deposit(double amount)
{
 	if (amount != monthlyDepositAmount)
    {
        throw new Exception();
    }
    else
    {
        Balance += amount
    }

}

public void Withdraw(double amount)
{
 	throw new NotImplementedException();
}
}
}
