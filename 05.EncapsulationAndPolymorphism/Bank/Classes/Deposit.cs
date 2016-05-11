using Bank.Interfaces;

namespace Bank.Classes
{
    public class Deposit : Account, IWithdraw
    {
        public Deposit(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return this.Balance;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}