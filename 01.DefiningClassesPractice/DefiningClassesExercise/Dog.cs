using System;

namespace DefiningClassesExercise
{
    public class Dog
    {
        private string name;
        private string breed;

        public Dog()
            : this(null, null)
        {
        }

        public Dog(string name)
            : this(name, null)
        {
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) says: Woof, woof!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }

        public override string ToString()
        {
            return string.Format("Dog {0} of breed {1}", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }
    }
}