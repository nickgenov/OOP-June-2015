using System;
using System.Collections.Generic;

namespace CalculateFigureArea
{
    public class CalculateFigureMain
    {
        static void Main()
        {
            var points = new List<Point>()
            {
                new Point(55.7, -4),
                new Point(7, 2),
                new Point(4, 4),
                new Point(55, -4),
            };

            var polygon = new Polygon(points);

            Console.WriteLine(polygon.Area);

            var a = new Point(3, 5);
            var b = new Point(-2, 7);

            Console.WriteLine(a.CalcDistance(b));
            Console.WriteLine(b.CalcDistance(a));
        }
    }
}