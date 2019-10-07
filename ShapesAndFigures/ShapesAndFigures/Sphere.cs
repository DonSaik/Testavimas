using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Sphere: Figure
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double GetArea()
        {
            if (radius <= 0)
            {
                return 0;
            }
            return 4 * Math.PI * radius * radius;
        }

        public override double GetBasePerimeter()
        {
            throw new Exception("Sphere has no base perimeter");
        }

        public override double GetVolume()
        {
            if (radius <= 0)
            {
                return 0;
            }
            return 4* Math.PI * Math.Pow(radius, 3)/3;
        }
    }
}
