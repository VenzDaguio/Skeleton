using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);

        }
        [TestMethod]
        public void SignUpDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.SignUpDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.SignUpDate, TestData);
        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);

        }
        [TestMethod]
        public void CustomerPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnCustomer.CustomerPayment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPayment, TestData);
        }
        [TestMethod]
        public void AccountInfoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnCustomer.AccountInfo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.AccountInfo, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CustomerID, TestData);
        }






    }
}
