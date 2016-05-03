using System;

namespace CalculateFigureArea
{
    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double CalcDistance(Point anotherPoint)
        {
            return Math.Sqrt((this.X - anotherPoint.X)*(this.X - anotherPoint.X) + (this.Y - anotherPoint.Y) * (this.Y - anotherPoint.Y));
        }
    }
}