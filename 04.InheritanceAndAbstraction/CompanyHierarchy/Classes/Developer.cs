using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<Project> projects) : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get
            {
                if (this.projects == null)
                {
                    this.projects = new List<Project>();
                }
                return this.projects;
            }
            set
            {
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("PersonID: {0}, name: {1} {2}, salary: {3}, department: {4}, projects:\n{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, string.Join("\n", this.Projects));

            return result;
        }
    }
}