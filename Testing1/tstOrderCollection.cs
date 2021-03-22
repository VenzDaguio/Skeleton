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
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 0;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
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

 //       [TestMethod]
 //       public void ListAndCountOK()
 //       {
 //           clsOrderCollection AllOrders = new clsOrderCollection();
 //           List<clsOrder> TestList = new List<clsOrder>();
  //          clsOrder TestItem = new clsOrder();
  //          TestItem.Delivered = true;
  //          TestItem.OrderId = 1;
  //          TestItem.CustomerId = 12;
  //          TestItem.OrderPrice = 2;
  //          TestItem.Description = "Blue Shirt";
  //          TestItem.Quantity = 10;
  //          TestItem.DateReceived = DateTime.Now.Date;
  //          TestList.Add(TestItem);
  //          AllOrders.OrderList = TestList;
  //          Assert.AreEqual(AllOrders.Count, TestList.Count);
 //       }
    }
} 
