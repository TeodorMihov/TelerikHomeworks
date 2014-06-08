namespace Euclidian3DSpace
{
    using System;

    //3. Write a static class with a static method to calculate the distance between two points in the 3D space.

    public static class Space3D
    {
        public static double CalculateDistanceBetweenTwoPoints(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt((first.X - second.X) * (first.X - second.X) +
                                        (first.Y - second.Y) * (first.Y - second.Y) +
                                        (first.Z - second.Z) * (first.Z - second.Z));
            return distance;
        }
    }
}
