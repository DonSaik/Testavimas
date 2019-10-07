using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Rectangle : Shape
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public override double GetArea()
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }
            return a * b;
        }

        public override double GetPerimeter()
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }
            return 2 * (a + b);
        }
    }
}
