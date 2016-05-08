using System;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }

        void CloseProject();
        string ToString();
    }
}