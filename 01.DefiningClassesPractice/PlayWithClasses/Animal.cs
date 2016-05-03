namespace PlayWithClasses
{
    public class Animal
    {
        private string name;

        public Animal()
        {
        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("I am a {0}", this.Name);
        }
    }
}