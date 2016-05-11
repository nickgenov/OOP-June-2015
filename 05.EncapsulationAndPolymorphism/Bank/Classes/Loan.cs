using Bank.Interfaces;

namespace Bank.Classes
{
    public class Loan : Account
    {
        private const int IndividualNoInterestPeriod = 3;
        private const int CompanyNoInterestPeriod = 2;

        public Loan(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                return base.CalculateInterest(months - IndividualNoInterestPeriod);
            }

            if (this.Customer is Company)
            {
                return base.CalculateInterest(months - CompanyNoInterestPeriod);
            }

            return base.CalculateInterest(months);
        }
    }
}