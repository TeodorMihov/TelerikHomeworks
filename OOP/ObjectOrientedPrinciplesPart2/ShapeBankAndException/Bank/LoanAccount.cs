namespace ShapeBankAndException.Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer custumer, decimal balance, decimal interestRate)
            :base(custumer,balance,interestRate)
        {
 
        }

        public override void Deposit(decimal sumToDeposit)
        {
            base.Balance += sumToDeposit;
        }
    }
}
