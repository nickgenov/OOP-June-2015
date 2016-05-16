using System;
using System.Collections.Generic;

namespace Persons
{
    public class PersonsMain
    {
        static void Main()
        {
            var persons = new List<Person>()
            {
                new Person("Pesho", 23),
                new Person("Stamat", 33),
                new Person("Misho", 29, "misho@gmail.com")
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}