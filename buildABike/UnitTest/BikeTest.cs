using System;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BikeTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod]
        public void FrameSizeTest()
        {
            Bike target = new Bike();
            int expected = 2;
            target.FrameSize = expected;
            Assert.AreEqual(expected, target.FrameSize);
        }
        [TestMethod]
        public void FrameColourTest()
        {
            Bike target = new Bike();
            int expected = 1;
            target.FrameColour = expected;
            Assert.AreEqual(expected, target.FrameColour);
        }
        [TestMethod]
        public void GearsTest()
        {
            Bike target = new Bike();
            int expected = 1;
            target.Gears = expected;
            Assert.AreEqual(expected, target.Gears);
        }
        [TestMethod]
        public void BrakesTest()
        {
            Bike target = new Bike();
            int expected = 1;
            target.Brakes = expected;
            Assert.AreEqual(expected, target.Brakes);
        }
        [TestMethod]
        public void WheelsTest()
        {
            Bike target = new Bike();
            int expected = 1;
            target.Wheels = expected;
            Assert.AreEqual(expected, target.Wheels);
        }
        [TestMethod]
        public void HandlebarTest()
        {
            Bike target = new Bike();
            int expected = 2;
            target.Handlebar = expected;
            Assert.AreEqual(expected, target.Handlebar);
        }
        [TestMethod]
        public void SaddleTest()
        {
            Bike target = new Bike();
            int expected = 1;
            target.Saddle = expected;
            Assert.AreEqual(expected, target.Saddle);
        }
        [TestMethod]
        public void ExtraWarrantyTest()
        {
            Bike target = new Bike();
            bool expected = true;
            target.ExtraWarranty = expected;
            Assert.AreEqual(expected, target.ExtraWarranty);
        }
        [TestMethod]
        public void PriceTest()
        {
            Bike target = new Bike(1,1,1,2,2,2,2,true);
            int expected = 435;
            Assert.AreEqual(expected, target.Price);
        }

        [TestMethod]
        public void DeliveryTest()
        {
            Bike target = new Bike(1, 1, 1, 2, 2, 2, 2, true);
            int expected = 80;
            Assert.AreEqual(expected, target.Hours);
        }
    }
}
