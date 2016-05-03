using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DefiningClassesExercise
{
    class Program
    {
        static void Main()
        {
            var sharo = new Dog("Sharo");
            var misho = new Dog("Misho", "pincher");
            var stamat = new Dog("Stamat", "german shepherd");
            var melez = new Dog();

            var dogs = new List<Dog>()
            {
                sharo,
                misho,
                stamat,
                melez
            };

            foreach (var dog in dogs)
            {
                dog.Bark();
            }

        }
    }
}
