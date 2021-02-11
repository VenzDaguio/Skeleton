using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void DataReceivedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DataReceived = TestData;
            Assert.AreEqual(AnOrder.DataReceived, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Decimal TestData = 1;
            AnOrder.OrderPrice = TestData;
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void DeliveredPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Delivered = TestData;
            Assert.AreEqual(AnOrder.Delivered, TestData);
        }

        [TestMethod]
        public void OrderDescriptionPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "A small blue shirt";
            AnOrder.Description = TestData;
            Assert.AreEqual(AnOrder.Description, TestData);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderLineId = TestData;
            Assert.AreEqual(AnOrder.OrderLineId, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
    }
}
