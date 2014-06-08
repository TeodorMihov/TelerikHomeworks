namespace ShapeBankAndException.Bank
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer custumer, decimal balance, decimal interestRate)
            :base(custumer,balance,interestRate)
        {

        }

        public override void Deposit(decimal sumToDeposit)
        {
            base.Balance += sumToDeposit;
        }

        public override void DrawMoney(decimal sumToDraw)
        {
            base.Balance -= sumToDraw;
        }
    }
}
