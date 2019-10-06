using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void PerimeterTest()
        {
            double r = 5.5;
            double expectedResult = 34.557519;
            Circle c = new Circle(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PerimeterWithZeroTest()
        {
            double r = 0;
            double expectedResult = 0;
            Circle c = new Circle(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PerimeterWithNegativeTest()
        {
            double r = -10;
            double expectedResult = 0;
            Circle c = new Circle(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AreaTest()
        {
            double r = 5.5;
            double expectedResult = 95.033178;
            Circle c = new Circle(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void AreaWithZeroTest()
        {
            double r = 0;
            double expectedResult = 0;
            Circle c = new Circle(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void AreaWithNegativeTest()
        {
            double r = -10;
            double expectedResult = 0;
            Circle c = new Circle(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }

    }
}
