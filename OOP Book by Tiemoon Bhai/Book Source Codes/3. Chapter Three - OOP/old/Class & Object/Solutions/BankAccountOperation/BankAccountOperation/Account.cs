namespace BankAccountOperation
{
    public class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;

        public string Deposit(double amount)
        {
            balance += amount;
            return amount + " taka has been deposited."; 
        }

        public string Withdraw(double amount)
        {
            balance -= amount;
            return amount + " taka has been withdrawn.";
        }
    }
}
