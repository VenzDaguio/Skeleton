using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ClothesColour = "red";
            TestItem.ClothesDescription = "LargeShirt";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 1;

            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);

        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.ClothesColour = "red";
            TestStock.ClothesDescription = "LargeShirt";
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;

            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Int32 SomeCount = 0;
            AllStocks.Count = SomeCount;
            Assert.AreEqual(AllStocks.Count, SomeCount);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.ClothesColour = "red";
            TestItem.ClothesDescription = "LargeShirt";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 1;
            TestItem.Available = true;
            TestItem.ClothesNo = 1;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.AreEqual(AllStocks.Count, 2);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ClothesColour = "red";
            TestItem.ClothesDescription = "LargeShirt";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 1;
            TestItem.Available = true;
            TestItem.ClothesNo = 1;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }












    }
        

    
}
