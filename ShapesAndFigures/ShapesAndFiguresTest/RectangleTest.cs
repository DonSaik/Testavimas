using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void rectangleAreaTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedArea = 1.5625;
            Rectangle r = new Rectangle(lenght, width);
            double actualArea = r.GetArea();
            Assert.AreEqual(expetedArea, actualArea);
        }

        [TestMethod]
        public void rectanglePerimeterTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedPerimeter = 5;
            Rectangle r = new Rectangle(lenght, width);
            double actualPerimeter = r.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);

        }
    }
}
