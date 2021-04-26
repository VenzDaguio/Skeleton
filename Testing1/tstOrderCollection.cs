using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 12;
            TestItem.OrderPrice = 2;
            TestItem.Description = "Blue Shirt";
            TestItem.Quantity = 10;
            TestItem.DateReceived = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Delivered = true;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 12;
            TestOrder.OrderPrice = 2;
            TestOrder.Description = "Blue Shirt";
            TestOrder.Quantity = 10;
            TestOrder.DateReceived = DateTime.Now.Date;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 12;
            TestItem.OrderPrice = 2;
            TestItem.Description = "Blue Shirt";
            TestItem.Quantity = 10;
            TestItem.DateReceived = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.OrderPrice = 1;
            TestItem.DateReceived = DateTime.Now.Date;
            TestItem.Description = "Blue Shirt";
            TestItem.Quantity = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Delivered = true;
            TestItem.CustomerId = 1;
            TestItem.OrderPrice = 1;
            TestItem.DateReceived = DateTime.Now.Date;
            TestItem.Description = "Blue Shirt";
            TestItem.Quantity = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;

            TestItem.Delivered = false;
            TestItem.CustomerId = 2;
            TestItem.OrderPrice = 2;
            TestItem.DateReceived = DateTime.Now.Date;
            TestItem.Description = "Pink Shirt";
            TestItem.Quantity = 2;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Delivered = true;
            TestItem.CustomerId = 1;
            TestItem.OrderPrice = 1;
            TestItem.DateReceived = DateTime.Now.Date;
            TestItem.Description = "Blue Shirt";
            TestItem.Quantity = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDescriptionMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDescription("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDescriptionNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDescription("xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }
    }
}
