using System;

namespace ValidPerson
{
    public class Person : IPerson
    {
        private const int MinPersonAge = 0;
        private const int MaxPersonAge = 120;

        string firstName;
        string lastName;
        int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName", "First name cannot be null, empty or whitespace.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("LastName", "LastName cannot be null, empty or whitespace.");
                }
                this.lastName = value;
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
                if (value < MinPersonAge || value > MaxPersonAge)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age must be in the range [0...120].");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person name: {0} {1}, age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}