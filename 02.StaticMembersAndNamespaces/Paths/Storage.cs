using System;
using System.IO;
using System.Linq;

namespace Paths
{
    public static class Storage
    {
        public static Path3D LoadFromTextFile(string filePath)
        {
            Path3D result = new Path3D();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] coordinates = line.Split(' ').Select(Double.Parse).ToArray();
                    double x = coordinates[0];
                    double y = coordinates[1];
                    double z = coordinates[2];

                    Point3D point = new Point3D(x, y, z);
                    result.Points.Add(point);

                    line = reader.ReadLine();
                }
            }

            Console.WriteLine("File loaded.");
            return result;
        }

        public static void SaveToTextFile(string filePath, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var point3D in path.Points)
                {
                    double x = point3D.XCoord;
                    double y = point3D.YCoord;
                    double z = point3D.ZCoord;

                    string line = string.Format("{0} {1} {2}", x, y, z);

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Saved to file.");
        }
    }
}