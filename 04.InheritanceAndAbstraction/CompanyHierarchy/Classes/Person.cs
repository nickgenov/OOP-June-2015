using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id", "Id cannot be a negative number.");
                }
                this.id = value;
            }
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
                    throw new ArgumentException("FirstName cannot be null or an empty string.", "FirstName");
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
                    throw new ArgumentException("LastName cannot be null or an empty string.", "LastName");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}", this.Id, this.FirstName, this.LastName);

            return result;
        }
    }
}