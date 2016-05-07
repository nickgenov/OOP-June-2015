using System;
using Animals.Enums;

namespace Animals.Classes
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} ({1} {2}) says: Woof, woof!", this.Name, this.Gender, this.GetType().Name);
        }
    }
}