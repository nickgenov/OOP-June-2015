using System;

namespace PlayWithClasses
{
    class Program
    {
        static void Main()
        {
            var r = new Rectangle(20, 30);
            Console.WriteLine(r);

            var r2 = new Rectangle(5);
            Console.WriteLine(r2.Area);

            r2.Height = 10;

            var a = new Apple();
            a.Price = 3.5M;

            Console.WriteLine(a.Price);
        }
    }
}