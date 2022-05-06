using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);

            //====================StockAvailable======================================
            [TestMethod]

            public void StockAvailableOK()
            {
                clsStock AStock = new clsStock();
                Boolean TestData = true;
                AStock.Available = TestData;
                Assert.AreEqual(AStock.Available, TestData);
            }
           
            //====================StockQuantity======================================
            [TestMethod]

            public void StockQuantityOK()
            {
                clsStock AStock = new clsStock();
                Int32 TestData = 1;
                AStock.StockQuantity = TestData;
                Assert.AreEqual(AStock.StockQuantity, TestData);
            }
            //====================Price======================================
            [TestMethod]

            public void PriceOK()
            {
                clsStock AStock = new clsStock();
                Decimal TestData = 20;
                AStock.Price = TestData;
                Assert.AreEqual(AStock.Price, TestData);
            }
            //====================DateAdded======================================

            [TestMethod]

            public void DateAddedOK()
            {
                clsStock AStock = new clsStock();
                DateTime TestData = DateTime.Now.Date;
                AStock.DateAdded = TestData;
                Assert.AreEqual(AStock.DateAdded, TestData);
            }
            //====================StockName======================================

            [TestMethod]

            public void StockNameOK()
            {
                clsStock AStock = new clsStock();
                String TestData = "Nike";
                AStock.StockName = TestData;
                Assert.AreEqual(AStock.StockName, TestData);
            }
            //====================StockID======================================

            [TestMethod]

            public void StockIDOK()
            {
                clsStock AStock = new clsStock();
                Int32 TestData = 1;
                AStock.StockID = TestData;
                Assert.AreEqual(AStock.StockID, TestData);
            }

            //====================FindMethod===================================

            [TestMethod]

            public void FindMethodOK()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Int32 StockID = 1;
                Found = AStock.find(StockID);
                Assert.IsTrue(Found);
            }
            //====================StockIDFound=============================

            [TestMethod]

            public void TestStockIDFound()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StockID = 1;
                Found = AStock.Find(StockID);
                if (AStock.StockID != 1)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            //====================StockNameFound=============================

            [TestMethod]

            public void TestStockNameFound()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StockID = 1;
                Found = AStock.Find(StockID);
                if (AStock.StockName != "Nike")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            //====================StockQuantityFound=============================

            [TestMethod]

            public void TestStockQuantityFound()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StockID = 1;
                Found = AStock.Find(StockID);
                if (AStock.StockQuantity != 1)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            //====================DateAdded=============================

            [TestMethod]

            public void DateAddedFound()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StockID = 1;
                Found = AStock.Find(StockID);
                if (AStock.DateAdded != Convert.ToDateTime("01/04/2022");
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            //====================Price=============================

            [TestMethod]

            public void TestPriceFound()
            {
                clsStock AStock = new clsStock();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StockID = 1;
                Found = AStock.Find(StockID);
                if (AStock.Price != 1)
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        //====================StockAvailableFound=============================

        [TestMethod]

        public void TestStockNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AStock.Find(StockID);
            if (AStock.StockAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
    }
}
