using System;
using System.Collections.Generic;
using Shapes.Classes;
using Shapes.Interfaces;

namespace Shapes
{
    public class ShapesMain
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(3.5),
                new Rectangle(5, 5),
                new Rhombus(2, 1)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}, area: {1:F2}, perimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}