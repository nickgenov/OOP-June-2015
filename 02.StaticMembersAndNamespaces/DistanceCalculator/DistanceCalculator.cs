namespace DistanceCalculator
{
    using System;
    using Point3D;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt((a.XCoord - b.XCoord) * (a.XCoord - b.XCoord) + (a.YCoord - b.YCoord) * (a.YCoord - b.YCoord) + (a.ZCoord - b.ZCoord) * (a.ZCoord - b.ZCoord));

            return distance;
        }
    }
}