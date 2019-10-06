using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public override double GetArea()
        {
            if(a<=0 || b<=0 || c <= 0)
            {
                return 0;
            }
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }

        public override double GetPerimeter()
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return 0;
            }
            return a + b + c;
        }
    }
}
