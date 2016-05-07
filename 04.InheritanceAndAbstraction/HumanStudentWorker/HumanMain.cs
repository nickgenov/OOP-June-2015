using System;
using System.Collections.Generic;
using System.Linq;
using HumanStudentWorker.People;

namespace HumanStudentWorker
{
    public class HumanMain
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Minka", "Petrova", "1234567890"),
                new Student("Georgi", "Ivanov", "6545651321"),
                new Student("Todor", "Minchev", "1321312333"),
                new Student("Petar", "Petrov", "8532121321"),
                new Student("Gergana", "Petrova", "4821245555"),
                new Student("Ivan", "Ivanov", "1234567890"),
                new Student("Strahil", "Iliev", "A132132325"),
                new Student("Trifon", "Dimitrov", "132AS15515"),
                new Student("Dimitar", "Ivanov", "FF54565656"),
                new Student("Maria", "Ivanova", "asd5645645"),
            };

            students = students.OrderBy(s => s.FacultyNumber).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            var workers = new List<Worker>()
            {
                new Worker("Penka", "Petrova", 200M, 40),
                new Worker("Minko", "Ivanov", 220M, 45),
                new Worker("Lazar", "Minchev", 300M, 20),
                new Worker("Gincho", "Petrov", 400M, 60),
                new Worker("Vera", "Petrova", 210M, 30),
                new Worker("Zlatyo", "Ivanov", 220M, 50),
                new Worker("Angel", "Iliev", 300M, 43),
                new Worker("Oleg", "Dimitrov", 330M, 45),
                new Worker("Filip", "Ivanov", 1200M, 46),
                new Worker("Jeni", "Ivanova", 230M, 41),
            };

            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}