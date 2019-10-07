using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndFigures
{
    public class Pyramid : Figure
    {
        private double baseLenght;
        private double height;

        public Pyramid(double height, double baseLenght)
        {
            this.Height = height;
            this.BaseLenght = baseLenght;
        }

        public double BaseLenght { get => baseLenght; set => baseLenght = value; }
        public double Height { get => height; set => height = value; }

        public override double GetArea()
        {
            if(baseLenght <= 0 || height <= 0)
            {
                return 0;
            }
            return baseLenght*(baseLenght + Math.Sqrt(baseLenght*baseLenght + 4*height*height));
        }

        public override double GetBasePerimeter()
        {
            if (baseLenght <= 0 || height <= 0)
            {
                return 0;
            }
            return baseLenght * 4;
        }

        public override double GetVolume()
        {
            if (baseLenght <= 0 || height <= 0)
            {
                return 0;
            }
            return 1 * baseLenght * baseLenght * height/3;
        }
    }
}
