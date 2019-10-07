using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Circle : Shape
    {
        // Area of a circle: A=πr2
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            double pi = Math.PI;
            double GetArea = pi * (radius * radius);
            return GetArea;
        }

        public override double GetPerimeter()
        {
            // Perimeter (Circumference) of a circle: C=2πr
            double pi = Math.PI;
            double GetPerimeter = 2 * pi * radius;
            return GetPerimeter;
        }
    }
}
