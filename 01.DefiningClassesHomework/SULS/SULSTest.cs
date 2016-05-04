using System.Collections.Generic;
using System.Linq;

namespace SULS
{
    class SULSTest
    {
        static void Main()
        {
            var people = new List<Person>()
            {
                new JuniorTrainer("Atanas", "Rusenov", 22),
                new SeniorTrainer("Svetlin", "Nakov", 36),
                new DropoutStudent("Stamat", "Stamatov", 28, 10002500362, 2, "went to the beach"),
                new GraduateStudent("Pesho", "Peshev", 27, 10002500568, 4.95),
                new OnlineStudent("Georgi", "Ivanov", 30, 10002500552, 4.2, "OOP"),
                new OnlineStudent("Minko", "Ivanov", 26, 10002500752, 3.2, "OOP"),
                new OnlineStudent("Penka", "Petrova", 28, 10002500832, 5.1, "OOP"),
                new OnsiteStudent("Ivan", "Ivanov", 22, 10002500320, 4.3, "OOP", 10),
                new OnsiteStudent("Minka", "Georgieva", 33, 10002500320, 3.3, "OOP", 5),
            };

            //TODO linq filter and sort

            //TODO override toString() in Trainer and Student to be able to print them
        }
    }
}