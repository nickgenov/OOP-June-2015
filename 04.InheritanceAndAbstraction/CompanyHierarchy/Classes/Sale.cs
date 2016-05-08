using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("ProductName cannot be null or an empty string.", "ProductName");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be a negative number.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Product sold: {0}, date of sale: {1}, price: {2}", this.ProductName,
                this.Date.Date, this.Price);

            return result;
        }
    }
}