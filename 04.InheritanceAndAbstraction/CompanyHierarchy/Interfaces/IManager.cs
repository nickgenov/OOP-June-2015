using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface IManager : IEmployee
    {
        List<Employee> Employees { get; set; }
    }
}