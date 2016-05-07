using System;
using Animals.Enums;

namespace Animals.Classes
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} ({1} {2}) says: Meeooow!", this.Name, this.Gender, this.GetType().Name);
        }
    }
}