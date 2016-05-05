using System;

namespace PCCatalog
{
    public class Component
    {
        private string name;
        private decimal price;
        private string details;

        public Component(string name, decimal price)
            : this(name, price, null)
        {
        }

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
                
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or an empty string.");
                }
                this.name = value;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be a negative number.");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException( "Details cannot be an empty string.");
                }
                this.details = value;
            }
        }       
    }
}