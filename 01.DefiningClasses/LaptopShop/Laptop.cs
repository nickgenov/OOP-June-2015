using System;

namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, string manufacturer, decimal price)
            : this(model, manufacturer, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, string manufacturer, string processor, string ram, decimal price)
            : this (model, manufacturer, processor, ram, null, null, null, null, price)
        {
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Model cannot be null or an empty string.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer cannot be null or an empty string.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Processor cannot be null or an empty string.");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Ram cannot be null or an empty string.");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Graphics card cannot be null or an empty string.");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Hdd cannot be null or an empty string.");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Screen cannot be null or an empty string.");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
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
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, price: {1:C}, manufacturer: {2}", this.Model, this.Price,
                this.Manufacturer ?? "[unknown]");
        }
    }
}