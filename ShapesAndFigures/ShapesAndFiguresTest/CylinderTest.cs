using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class CylinderTest
    {
        [TestMethod]
        public void ConeBasePerimeterTest()
        {
            Cylinder cylinder = new Cylinder(11.5, 10);
            double actualPerimeter = cylinder.GetBasePerimeter();
            double expectedPerimeter = 72.2566;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void ConeBasePerimeterWithNegativesTest()
        {
            Cylinder cylinder = new Cylinder(-11.5, 10);
            double actualPerimeter = cylinder.GetBasePerimeter();
            double expectedPerimeter = 0;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void ConeAreaTest()
        {
            Cylinder cylinder = new Cylinder(11.5, 12.5);
            double actualArea = cylinder.GetArea();
            double expectedArea = 1734.15914478;
            Assert.AreEqual(expectedArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void ConeAreaWithNegativesTest(double radius, double height, double expecterArea)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            double actualArea = cylinder.GetArea();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void ConeVolumeWithNegativesTest(double radius, double height, double expecterArea)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            double actualArea = cylinder.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(11.2, 12.5, 4926.01728)]
        [DataRow(35.9, 0.2, 809.7832)]
        [TestMethod]
        public void ConeVolumeTest(double radius, double height, double expecterArea)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            double actualArea = cylinder.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.01);

        }
    }
}
