using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees) : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get
            {
                if (this.employees == null)
                {
                    this.employees = new List<Employee>();
                }
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}, salary: {3}, department: {4}, managed employees:\n{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, string.Join("\n", this.Employees));

            return result;
        }
    }
}