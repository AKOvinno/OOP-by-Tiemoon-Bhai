namespace BankApplicationExample
{
    class Account
    {
        public string Number { set; get; }
        public string AccountType { set; get; }
        public double Balance { private set; get; }

        public Account(string number, string accountType)
            : this()
        {
            Number = number;
            AccountType = accountType;
        }

        public Account()
        {
            Balance = 0;
        }


        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return "Withdrawn";
            }
            else
            {
                return "No sufficient balance to withdraw";
            }
        }
    }
}
