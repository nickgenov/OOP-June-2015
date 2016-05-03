namespace PlayWithClasses
{
    public class Cat : Animal
    {
        private string owner;

        public Cat(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
    }
}