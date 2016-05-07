using System;
using System.Collections.Generic;
using System.Linq;
using Animals.Classes;
using Animals.Enums;

namespace Animals
{
    public class AnimalsMain
    {
        static void Main()
        {
            var animals = new List<Animal>()
            {
                new Dog("Rex", 3, Gender.Male),
                new Dog("Sarah", 2, Gender.Female),
                new Dog("Pesho", 8, Gender.Male),
                new Frog("Minka", 1, Gender.Female),
                new Frog("Pencho", 2, Gender.Male),
                new Kitten("Maria", 4),
                new Kitten("Elza", 1),
                new Kitten("Pipi", 6),
                new Tomcat("Stamat", 2),
                new Tomcat("Pepi", 5),
                new Tomcat("Gosho", 4),
                new Tomcat("Pesho", 1),
            };

            foreach (var animal in animals)
            {
                animal.ProduceSound();
            }
            Console.WriteLine();

            var dogsAverageAge = animals.Where(a => a.GetType().Name == "Dog").Average(d => d.Age);

            var frogsAverageAge = animals.Where(a => a.GetType().Name == "Frog").Average(f => f.Age);

            var kittensAverageAge = animals.Where(a => a.GetType().Name == "Kitten").Average(k => k.Age);

            var tomcatsAverageAge = animals.Where(a => a.GetType().Name == "Tomcat").Average(t => t.Age);

            Console.WriteLine("Dogs average age: {0:F2}", dogsAverageAge);
            Console.WriteLine("Frogs average age: {0:F2}", frogsAverageAge);
            Console.WriteLine("Kittens average age: {0:F2}", kittensAverageAge);
            Console.WriteLine("Tomcats average age: {0:F2}", tomcatsAverageAge);
        }
    }
}