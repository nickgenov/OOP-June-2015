using System;
using System.Collections.Generic;

namespace LaptopShop
{
    public class LaptopShopMain
    {
        static void Main()
        {
            var laptopOne = new Laptop("HP 250 G2", 699.0M);

            var laptopTwo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), 2259.00M);

            var laptops = new List<Laptop>()
            {
                laptopOne,
                laptopTwo
            };

            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop);
            }
        }
    }
}