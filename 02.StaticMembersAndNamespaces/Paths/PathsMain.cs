using System;

namespace Paths
{
    public class PathsMain
    {
        static void Main()
        {
            string filePath = @"..\..\PathToLoad.txt";

            Path3D pathOfPoints3D = Storage.LoadFromTextFile(filePath);

            foreach (var point3D in pathOfPoints3D.Points)
            {
                Console.WriteLine(point3D);
            }

            filePath = @"..\..\PathToSave.txt";

            Storage.SaveToTextFile(filePath, pathOfPoints3D);
        }
    }
}