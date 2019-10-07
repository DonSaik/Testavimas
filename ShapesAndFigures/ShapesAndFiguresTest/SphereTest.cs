using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class SphereTest
    {
        [TestMethod]
        public void PerimeterTest()
        {
            double r = 5.5;
            double expectedResult = 34.557519;
            Sphere s = new Sphere(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PerimeterWithZeroTest()
        {
            double r = 0;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PerimeterWithNegativeTest()
        {
            double r = -10;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = c.GetPerimeter();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AreaTest()
        {
            double r = 5.5;
            double expectedResult = 95.033178;
            Sphere s = new Sphere(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void AreaWithZeroTest()
        {
            double r = 0;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void AreaWithNegativeTest()
        {
            double r = -10;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = c.GetArea();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SphereAreaWithNegativesTest(double radius, double expecterArea)
        {
            Sphere s = new Sphere(radius);
            double actualArea = sphere.GetArea();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [TestMethod]
        public void SphereVolumeWithNegativesTest(double radius, double expecterArea)
        {
            Sphere s = new Sphere(radius);
            double actualArea = sphere.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [TestMethod]
        public void SphereVolumeTest(double radius, double expecterArea)
        {
            Sphere s = new Sphere(radius);
            double actualArea = sphere.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.01);

        }

    }
}
