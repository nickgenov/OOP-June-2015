using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee : IRegularEmployee
    {
        List<Sale> Sales { get; set; }
    }
}