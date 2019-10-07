using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Cone : Figure
    {
        double radius, h;
        double PI = 3.14;


        public Cone(double radius, double height)
        {

        }
        public override double GetArea()
        {
            double GetArea = PI * radius * (radius + Math.Sqrt(radius * radius + h * h));
            return GetArea;
        }

        public override double GetBasePerimeter()
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            double GetVolume = (1.0 / 3) * PI * radius * radius * h;
            return GetVolume;
        }
    }
}
