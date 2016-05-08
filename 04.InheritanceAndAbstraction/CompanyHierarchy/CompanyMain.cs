using System;
using System.Collections.Generic;
using CompanyHierarchy.Classes;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy
{
    public class CompanyMain
    {
        static void Main()
        {
            var developerOne = new Developer(5, "Ivan", "Ivanov", 2000, Department.Production, new List<Project>() {new Project("website", DateTime.Today, "company site", State.Open)});
            var developerTwo = new Developer(6, "Dimitar", "Ivanov", 2500, Department.Production, new List<Project>() { new Project("website", DateTime.Today, "company site", State.Open) });
            var productionManager = new Manager(1, "Maria", "Ivanova", 3000, Department.Production, new List<Employee>() {developerOne, developerTwo});

            var salesOne = new SalesEmployee(3, "Todor", "Ivanov", 1000, Department.Sales,
                new List<Sale>() {new Sale("License", DateTime.Today, 85)});
            var salesTwo = new SalesEmployee(4, "Iva", "Ivanova", 1000, Department.Sales,
                new List<Sale>() {new Sale("License", DateTime.Today, 85)});
            var salesManager = new Manager(2, "Petar", "Petrov", 2000, Department.Sales,
                new List<Employee>() {salesOne, salesTwo});


            var employees = new List<Employee>()
            {
                developerOne,
                developerTwo,
                productionManager,
                salesOne,
                salesTwo,
                salesManager
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}