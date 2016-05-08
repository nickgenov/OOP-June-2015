using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount) : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("NetPurchaseAmount", "NetPurchaseAmount cannot be a negative number.");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}, net purchase amount: {3:F2}", this.Id, this.FirstName, this.LastName, this.NetPurchaseAmount);

            return result;
        }
    }
}