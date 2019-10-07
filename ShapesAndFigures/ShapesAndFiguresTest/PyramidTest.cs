using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class PyramidTest
    {
        [TestMethod]
        public void PyramidBasePerimeterTest()
        {
            Pyramid pyramid = new Pyramid(11.5, 11.5);
            double actualPerimeter = pyramid.GetBasePerimeter();
            double expectedPerimeter = 57.5;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void PyramidBasePerimeterWithNegativesTest()
        {
            Pyramid pyramid = new Pyramid(-11.5, 10);
            double actualPerimeter = pyramid.GetBasePerimeter();
            double expectedPerimeter = 0;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void PyramidAreaTest()
        {
            Pyramid pyramid = new Pyramid(11.5, 12.5);
            double actualArea = pyramid.GetArea();
            double expectedArea = 132.25;
            Assert.AreEqual(expectedArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void PyramidAreaWithNegativesTest(double baseLenght, double height, double expecterArea)
        {
            Pyramid pyramid = new Pyramid(baseLenght, height);
            double actualArea = pyramid.GetArea();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void PyramidVolumeWithNegativesTest(double baseLenght, double height, double expecterArea)
        {
            Pyramid pyramid = new Pyramid(baseLenght, height);
            double actualArea = pyramid.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(11.2, 12.5, 1642.01)]
        [DataRow(35.9, 0.2, 269.928)]
        [TestMethod]
        public void PyramidVolumeTest(double baseLenght, double height, double expecterArea)
        {
            Pyramid pyramid = new Pyramid(baseLenght, height);
            double actualArea = pyramid.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.01);

        }
    }
}
