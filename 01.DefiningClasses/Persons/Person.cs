using System;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
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
                    throw new ArgumentNullException("Name cannot be null or an empty string");
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
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in the range [1...100].");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null)
                {
                    this.email = value;
                }
                else if (value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Email must either be null or a string, containing '@'.");
                }
                
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} is {1} years old. Email: {2}", this.Name, this.Age, this.Email ?? "[no email]");
        }
    }
}
