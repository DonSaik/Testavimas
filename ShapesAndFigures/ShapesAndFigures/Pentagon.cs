using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Pentagon : Shape
    {
        private double lenght;
        public Pentagon(double lenght)
        {
            this.Lenght = lenght;
        }

        public double Lenght { get => lenght; set => lenght = value; }

        public override double GetArea()
        {
            if (lenght <= 0)
            {
                return 0;
            }
            return ( 5*lenght*lenght*Math.Tan(Math.PI * 54 / 180.0))/4;
        }

        public override double GetPerimeter()
        {
            if(lenght <= 0)
            {
                return 0;
            }
            return lenght * 5;
        }
    }
}
