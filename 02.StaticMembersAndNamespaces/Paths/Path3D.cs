using System.Collections.Generic;

namespace Paths
{
    public class Path3D
    {
        public Path3D()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }
    }
}