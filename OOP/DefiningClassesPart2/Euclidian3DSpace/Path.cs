namespace Euclidian3DSpace
{
    using System;
using System.Collections.Generic;

    //4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

    public class Path
    {
        private List<Point3D> pointsList;

        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        public List<Point3D> PointList
        {
            get
            {
                return new List<Point3D>(this.pointsList);
            }
            set
            {
                this.pointsList = value;
            }
        }

        public void AddPoints(Point3D points)
        {
            this.pointsList.Add(points);
        }

        public void PrintPointsList()
        {
            foreach (var points in pointsList)
            {
                Console.WriteLine(points);
            }
        }
    }
}
