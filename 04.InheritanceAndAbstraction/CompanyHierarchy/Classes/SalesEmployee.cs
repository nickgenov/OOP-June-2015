using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales) : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get
            {
                if (this.sales == null)
                {
                    this.sales = new List<Sale>();
                }
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}, salary: {3}, department: {4}, sales:\n{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, string.Join("\n", this.Sales));

            return result;
        }
    }
}