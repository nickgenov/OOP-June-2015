using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateFigureArea
{
    public class Polygon
    {
        public Polygon(List<Point> points)
        {
            this.Points = points;
        }

        public List<Point> Points { get; set; }

        public double Area
        {
            get
            {
                double area = Math.Abs(this.Points.Take(this.Points.Count - 1)
                .Select((p, i) => (this.Points[i + 1].X - p.X) * (this.Points[i + 1].Y + p.Y))
                .Sum() / 2);

                return area;
            }
        }
    }
}