namespace FastBankAccountApp.Objects
{
    public class AccountHolder
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public Account AnAccount { set; get; }

        public AccountHolder(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public AccountHolder()
        {

        }
    }
}
