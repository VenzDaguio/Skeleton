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
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void Over18PropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Over18 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Over18, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variabke to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the methog
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variabke to store the result of the validation
            Boolean Found = false;
            //Boolean variable ro record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the methog
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        public void TestSignUpDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variabke to store the result of the validation
            Boolean Found = false;
            //Boolean variable ro record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the methog
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.SignUpDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerAdressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerAdress = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerAdress);
            //check the property
            if (AnCustomer.CustomerAddress != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPaymentFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerPayment = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerPayment);
            //check the property
            if (AnCustomer.CustomerPayment != "Test Payment")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable ro record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the methog
            Int32 DateOfBirth = 21;
            //invoke the method
            Found = AnCustomer.Find(DateOfBirth);
            //check the customers date of birth
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("16/09/2016"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOver18Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Over18 = 21;
            //invoke the method
            Found = AnCustomer.Find(Over18);
            //check the property
            if (AnCustomer.Over18 != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }







    }
}
