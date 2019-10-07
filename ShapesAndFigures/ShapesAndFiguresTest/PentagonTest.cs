using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class PentagonTest
    {
        [TestMethod]
        public void PentagonPerimeterTest()
        {
            double a = 1, b = 1, c = 1, d = 1, e = 1;
            double expetedPerimeter = 5;
            Pentagon p = new Pentagon(a, b, c, d, e);
            double actualPerimeter = t.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void PentagonAreaTest()
        {
            double a = 1, b = 1, c = 1, d = 1, e = 1;
            double expetedArea = 1.7205;
            Pentagon p = new Pentagon(a, b, c, d, e);
            double actualArea = t.GetArea();
            Assert.AreEqual(expetedArea, actualArea, 0.0001);
        }
    }

}
