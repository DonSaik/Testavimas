using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 1, b = 1, c = 1;
            double expetedArea = 0.43301;
            Triangle t = new Triangle(a, b, c);
            double actualArea = t.GetArea();
            Assert.AreEqual(expetedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TrianglePerimeterTest()
        {
            double a = 1, b = 1, c = 1;
            double expetedPerimeter = 3;
            Triangle t = new Triangle(a, b, c);
            double actualPerimeter = t.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);
        }

    }
}
