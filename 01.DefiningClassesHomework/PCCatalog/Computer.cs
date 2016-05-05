using System;
using System.Collections.Generic;

namespace PCCatalog
{
    public class Computer
    {
        private string name;
        private List<Component> components;
        private decimal price;

        public Computer(string name, List<Component> components, decimal price)
        {
            this.Name = name;
            this.Components = components;
            this.Price = price;
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

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                this.components = value;
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

        public void DisplayComputerInfo()
        {
            decimal totalComponentPrice = 0;
            Console.WriteLine("Computer name: {0}, price: {1:C}", this.Name, this.Price);

            foreach (var component in this.Components)
            {
                Console.WriteLine("Component name: {0}, component price: {1:C}", component.Name, component.Price);

                totalComponentPrice += component.Price;
            }
            Console.WriteLine();
        }
    }
}