using System;
using System.Collections.Generic;

namespace ValidPerson
{
    public class ValidPersonMain
    {
        static void Main()
        {
            var people = new List<Person>();

            try
            {
                var a = new Person("Ivan", "Ivanov", 32);
                people.Add(a);

                //var b = new Person("", "Dimitrova", 26);
                //people.Add(b);

                //var c = new Person("Georgi", null, 44);
                //people.Add(c);

                //var d = new Person("Stamat", "Stamatov", -10);
                //people.Add(d);

                var e = new Person("Minka", "Stamatova", 200);
                people.Add(e);

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Program finished!");
        }
    }
}