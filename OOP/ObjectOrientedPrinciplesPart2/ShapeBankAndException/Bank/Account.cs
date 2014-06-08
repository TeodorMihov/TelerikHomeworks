namespace ShapeBankAndException.Bank
{
    public abstract class Account
    {
        private Customer customer;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public abstract void Deposit(decimal sumToDeposit);

        public virtual void DrawMoney(decimal sumToDraw)
        {

        }
    }
}
