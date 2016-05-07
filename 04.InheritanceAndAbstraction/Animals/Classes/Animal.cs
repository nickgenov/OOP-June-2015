using System;
using Animals.Enums;
using Animals.Interfaces;

namespace Animals.Classes
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age) : this(name, age, Gender.Unknown)
        {
        }

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
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
                    throw new ArgumentException("Name cannot be null or an empty string", "Name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age cannot be a negative number.");
                }
                this.age = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Animal name: {0}, age: {1}, gender: {2}", this.Name, this.Age, this.Gender);
        }

        public abstract void ProduceSound();
    }
}