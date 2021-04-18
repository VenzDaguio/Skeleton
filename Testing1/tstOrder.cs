using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to the method
        string Description = "A blue shirt";
        string DateReceived = DateTime.Now.Date.ToString();

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
        public void DateReceivedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateReceived = TestData;
            Assert.AreEqual(AnOrder.DateReceived, TestData);
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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
   
        }

        [TestMethod]
        public void TestOrderPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderPrice != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveredFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Delivered != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Description != "Blue Shirt")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderLineId != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateReceivedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateReceived != Convert.ToDateTime("25/03/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(Description, DateReceived);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Description = "";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "t";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "tt";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "ttttttttttttttttttttttttttttttttttttttttttttttttt";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "tttttttttttttttttttttttttttttttttttttttttttttttttt";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "ttttttttttttttttttttttttt";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "ttttttttttttttttttttttttttttttttttttttttttttttttttt";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(500, 't');
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateReceived = TestDate.ToString();
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateReceived = TestDate.ToString();
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateReceived = TestDate.ToString();
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateReceived = TestDate.ToString();
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateReceived = TestDate.ToString();
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DataReceivedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DateReceived = "this is not a date!";
            Error = AnOrder.Valid(Description, DateReceived);
            Assert.AreNotEqual(Error, "");
        }
    }
}
