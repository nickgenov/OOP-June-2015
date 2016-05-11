using Bank.Interfaces;

namespace Bank.Classes
{
    public class Mortgage : Account
    {
        private const int CompanyHalfInterestPeriod = 12;
        private const int IndividualNoInterestPeriod = 6;

        public Mortgage(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Company)
            {
                return CalculateCompanyInterest(months);
            }

            if (this.Customer is Individual)
            {
                return CalculateIndividualInterest(months);
            }

            return base.CalculateInterest(months);
        }

        private decimal CalculateCompanyInterest(int months)
        {
            if (months <= CompanyHalfInterestPeriod)
            {
                return this.Balance * (1 + (this.InterestRate / 2) * months);
            }

            decimal firstPeriod = this.Balance * (1 + (this.InterestRate / 2) * CompanyHalfInterestPeriod);
            decimal secondPeriod = this.Balance * this.InterestRate * (months - CompanyHalfInterestPeriod);

            decimal totalBalance = firstPeriod + secondPeriod;
            return totalBalance;
        }

        private decimal CalculateIndividualInterest(int months)
        {
            if (months <= IndividualNoInterestPeriod)
            {
                return this.Balance;
            }

            return this.Balance * (1 + this.InterestRate * (months - IndividualNoInterestPeriod)); ;            
        }
    }
}