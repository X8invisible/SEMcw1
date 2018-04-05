using System;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class StocksTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void StockTestTrue()
        {
            Stocks instance = Stocks.Instance;
            bool target = instance.UpdateStocks(3, 2, 2, 2, 2, 2);
            Assert.AreEqual(true, target);
        }

        [TestMethod]
        public void StockTestFalse()
        {
            Stocks instance = Stocks.Instance;
            bool target = true;
            for(int i=0; i < 6; i++)
            {
                //takes 5 bikes to run out of stock on the frame attribute
                target = instance.UpdateStocks(3, 2, 2, 2, 2, 2);
            }
            Assert.AreEqual(false, target);
        }
    }
}
