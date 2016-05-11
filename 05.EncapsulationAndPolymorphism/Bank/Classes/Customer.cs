using System;
using Bank.Interfaces;

namespace Bank.Classes
{
    public abstract class Customer : ICustomer
    {
        private int id;
        private string name;

        protected Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Id", "Id must be a positive integer.");
                }
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whitespace", "Name");
                }
                this.name = value;
            }
        }
    }
}