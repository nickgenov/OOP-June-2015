namespace PlayWithClasses
{
    public class Apple
    {
        public Apple()
        {
            this.Price = null;
        }

        public Apple(decimal price)
        {
            this.Price = price;
        }

        public decimal? Price { get; set; }
    }
}