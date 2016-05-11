﻿namespace Shapes.Classes
{
    public class Rhombus : BasicShape
    {
          public Rhombus(double width, double height) : base(width, height)
        {
        }
        
        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width * 4;
            return perimeter;
        }
    }
}