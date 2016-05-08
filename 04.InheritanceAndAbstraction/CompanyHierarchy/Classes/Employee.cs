using System;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        protected Employee(int id, string firstName, string lastName, decimal salary, Department department) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary", "Salary cannot be a negative number.");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}, salary: {3}, department: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department);

            return result;
        }
    }
}