using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class PentagonTest
    {
        [TestMethod]
        public void PentagonPerimeterTest()
        {
            double a = 1;
            double expetedPerimeter = 5;
            Pentagon p = new Pentagon(a);
            double actualPerimeter = p.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void PentagonAreaTest()
        {
            double a = 1;
            double expetedArea = 1.7205;
            Pentagon p = new Pentagon(a);
            double actualArea = p.GetArea();
            Assert.AreEqual(expetedArea, actualArea, 0.0001);
        }
    }

}
