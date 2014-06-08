using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyGeometry
{
    public class Circle : GeometryAPI.Figure, GeometryAPI.IAreaMeasurable
    {
        private double radius;

        public Circle(Vector3D centerX, Vector3D centerY, Vector3D centerZ, Vector3D radius)
            :base(centerX,centerY,centerZ,radius)
        {

        }

        public double Radius 
        {
            get 
            { 
                return this.radius; 
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be null or negative!");
                }

                this.radius = value; 
            }
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
