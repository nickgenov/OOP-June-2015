namespace DistanceCalculator
{
    using System;
    using Point3D;

    public class CalculatorMain
    {
        static void Main()
        {
            var pointA = new Point3D(-7, -4, 3);
            var pointB = new Point3D(17, 6, 2.5);

            var distance = DistanceCalculator.CalculateDistance(pointA, pointB);

            Console.WriteLine(distance);
        }
    }
}