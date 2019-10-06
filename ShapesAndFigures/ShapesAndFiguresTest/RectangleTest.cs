using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedArea = 1.5625;
            Rectangle r = new Rectangle(lenght, width);
            double actualArea = r.GetArea();
            Assert.AreEqual(expetedArea, actualArea);
        }
        [DataRow(-1, 1, 0)]
        [DataRow(1, -1.5, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(-1.5, -1.5, 0)]
        [TestMethod]
        public void RectangleAreaWithNegativesTest(double lenght, double width, double expectedArea)
        {
            Rectangle r = new Rectangle(lenght, width);
            double actualArea = r.GetArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedPerimeter = 5;
            Rectangle r = new Rectangle(lenght, width);
            double actualPerimeter = r.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);

        }
        [DataRow(-1, 1, 0)]
        [DataRow(1, -1.5, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(-1.5, -1.5, 0)]
        [TestMethod]
        public void RectanglePerimeterWithNegativesTest(double lenght, double width, double expectedPerimeter)
        {

            Rectangle r = new Rectangle(lenght, width);
            double actualPerimeter = r.GetPerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);

        }
    }
}
