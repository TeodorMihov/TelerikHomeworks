namespace ShapeBankAndException.Bank
{
    public class MortageAccount : Account
    {
        public MortageAccount(Customer customer,decimal balance,decimal interestRate)
            :base(customer,balance,interestRate)
        {

        }

        public override void Deposit(decimal sumToDeposit)
        {
            base.Balance += sumToDeposit;
        }
    }
}
