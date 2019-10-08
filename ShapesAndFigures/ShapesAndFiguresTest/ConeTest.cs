using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    [TestClass]
    public class ConeTest
    {
        [TestMethod]
        public void ConeBasePerimeterTest()
        {
            Cone cone = new Cone( 11.5, 10);
            double actualPerimeter = cone.GetBasePerimeter();
            double expectedPerimeter = 72.2566;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void ConeBasePerimeterWithNegativesTest()
        {
            Cone cone = new Cone( -11.5, 10);
            double actualPerimeter = cone.GetBasePerimeter();
            double expectedPerimeter = 0;
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);

        }
        [TestMethod]
        public void ConeAreaTest()
        {
            Cone cone = new Cone( 11.5, 12.5);
            double actualArea = cone.GetArea();
            double expectedArea = 1029.125463 ;
            Assert.AreEqual(expectedArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void ConeAreaWithNegativesTest(double radius, double height, double expecterArea)
        {
            Cone cone = new Cone(radius, height);
            double actualArea = cone.GetArea();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(-1, 2, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [TestMethod]
        public void ConeVolumeWithNegativesTest(double radius, double height, double expecterArea)
        {
            Cone cone = new Cone(radius, height);
            double actualArea = cone.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.0001);

        }
        [DataRow(11.2, 12.5, 1642.005760)]
        [DataRow(35.9, 0.2, 269.927735)]
        [TestMethod]
        public void ConeVolumeTest(double radius, double height, double expecterArea)
        {
            Cone cone = new Cone(radius, height);
            double actualArea = cone.GetVolume();
            Assert.AreEqual(expecterArea, actualArea, 0.01);

        }
    }
}
