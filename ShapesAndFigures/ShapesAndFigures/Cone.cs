using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Cone : Figure
    {
        double radius;
        double h;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.h = height;
            
        }
        public override double GetArea()
        {
            if (radius <= 0 || h <=0)
            {
                return 0;
            }
            double pi = Math.PI;
            double GetArea = pi * radius * (radius + Math.Sqrt(radius * radius + h * h));
            return GetArea;
        }

        public override double GetBasePerimeter()
        {
            if (radius <= 0 || h <=0)
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
            double pi = Math.PI;
            double GetVolume = (1.0 / 3) * pi * radius * radius * h;
            return GetVolume;
        }
    }
}
