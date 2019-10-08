using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class SphereTest
    {
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void PerimeterTest()
        {
            double r = 5.5;
            double expectedResult = 34.557519;
            Sphere s = new Sphere(r);
            double result = s.GetBasePerimeter();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AreaTest()
        {
            double r = 5.5;
            double expectedResult = 380.132;
            Sphere s = new Sphere(r);
            double result = s.GetArea();
            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void AreaWithZeroTest()
        {
            double r = 0;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = s.GetArea();
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void AreaWithNegativeTest()
        {
            double r = -10;
            double expectedResult = 0;
            Sphere s = new Sphere(r);
            double result = s.GetArea();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SphereAreaWithNegativesTest()
        {
            double expecterArea = 0;
            Sphere s = new Sphere(-2);
            double actualArea = s.GetArea();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [TestMethod]
        public void SphereVolumeWithNegativesTest()
        {
            double expecterArea = 0;
            Sphere s = new Sphere(-2);
            double actualArea = s.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [TestMethod]
        public void SphereVolumeTest()
        {
            double expecterArea = 33.51;
            Sphere s = new Sphere(2);
            double actualArea = s.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.01);

        }

    }
}
