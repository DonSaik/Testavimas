using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAndFigures;

namespace ShapesAndFiguresTest
{
    /// <summary>
    /// Summary description for RectangleTest
    /// </summary>
    [TestClass]
    public class RectangleTest
    {
        public RectangleTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void rectangleAreaTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedArea = 1.5625;
            Rectangle r = new Rectangle(lenght, width);
            double actualArea = r.GetArea();
            Assert.AreEqual(expetedArea, actualArea);
        }

        [TestMethod]
        public void rectanglePerimeterTest()
        {
            double lenght = 1.25;
            double width = 1.25;
            double expetedPerimeter = 5;
            Rectangle r = new Rectangle(lenght, width);
            double actualPerimeter = r.GetPerimeter();
            Assert.AreEqual(expetedPerimeter, actualPerimeter);

        }

    }
}
