using System.Collections.Generic;
using System.Linq;

namespace PCCatalog
{
    public class Program
    {
        static void Main()
        {
            var componentsA = new List<Component>()
            {
                new Component("Intel i5 4200", 250),
                new Component("SSD Samsung 850 EVO", 300, "500 GB")
            };
            var computerA = new Computer("HP 450 G2", componentsA, 1600);

            var componentsB = new List<Component>()
            {
                new Component("Intel i5 5500", 350),
                new Component("SSD Samsung 850 Pro", 200, "256 GB")
            };
            var computerB = new Computer("HP 450 G3", componentsB, 1500);

            var computers = new List<Computer>()
            {
                computerA,
                computerB
            };

            computers = computers.OrderBy(c => c.Price).ToList();

            foreach (var computer in computers)
            {
                computer.DisplayComputerInfo();
            }
        }
    }
}