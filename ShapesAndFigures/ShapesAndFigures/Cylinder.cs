using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Cylinder:Figure
    {
        double radius;
        double h;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.h = height;
        }

        public override double GetArea()
        {
            if (radius <= 0 || h <= 0)
            {
                return 0;
            }
            double pi = Math.PI;
            double GetArea = 2 * pi * radius * (radius + h);
            return GetArea;
        }

        public override double GetBasePerimeter()
        {
            if (radius <= 0 || h <= 0)
            {
                return 0;
            }
            double pi = Math.PI;
            double GetPerimeter = 2 * pi * radius;
            return GetPerimeter;
        }

        public override double GetVolume()
        {
            if (radius <= 0 || h <=0)
            {
                return 0;
            }
            double GetVolume = Math.PI * radius * radius * h;
            return GetVolume;
        }
    }
}
