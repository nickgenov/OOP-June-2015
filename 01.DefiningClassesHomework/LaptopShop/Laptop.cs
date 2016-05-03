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

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string Processor { get; set; }

        public string Ram { get; set; }

        public string GraphicsCard { get; set; }

        public string Hdd { get; set; }

        public string Screen { get; set; }

        public Battery Battery { get; set; }

        public decimal Price { get; set; }
    }
}