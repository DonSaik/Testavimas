using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Circle c = Circle(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AreaTest()
        {
            double r = 5.5;
            double expectedResult = 95.033178;
            Circle c = Circle(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
