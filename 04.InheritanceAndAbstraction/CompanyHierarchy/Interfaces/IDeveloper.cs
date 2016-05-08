using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface IDeveloper : IRegularEmployee
    {
        List<Project> Projects { get; set; }
    }
}