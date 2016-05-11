using System;
using Bank.Interfaces;

namespace Bank.Classes
{
    public abstract class Account : IAccount, IDeposit, ICalculateInterest
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance", "Balance cannot be negative.");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("InterestRate", "InterestRate cannot be negative.");
                }
                this.interestRate = value;
            }
        }


        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                months = 0;
            }

            decimal result = this.Balance * (1 + this.InterestRate * months);
            return result;
        }
    }
}