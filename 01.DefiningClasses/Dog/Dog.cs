using System;

namespace Dog
{
    public class Dog
    {
        private string name;
        private string breed;

        public Dog() 
            : this(null, null)
        {
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Name cannot be null, empty or whitespace.", "Name");
                //}

                this.name = value;
            }
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Breed cannot be null, empty or whitespace.", "Breed");
                //}
                this.breed = value;
            }
        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }
    }
}