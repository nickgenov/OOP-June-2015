using System;
using Shapes.Interfaces;

namespace Shapes.Classes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius", "Radius cannot be a negative number.");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
    }
}