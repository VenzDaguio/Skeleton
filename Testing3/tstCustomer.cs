using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer

    {
        //good test data
        //create some test data to pass to the method
        string CustomerAddress = "Address for Customer";
        string CustomerPayment = "Payment Info";
        string SignUpDate = DateTime.Now.ToString();
        string DateOfBirth = DateTime.Now.Date.ToString();
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
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variabke to store the result of the validation
            Boolean Found = false;
            //Boolean variable ro record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the methog
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerID != 1)
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
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.SignUpDate != Convert.ToDateTime("12/12/2019"))
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.CustomerAddress != "Western Road")
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.CustomerPayment != "Siren Ocean etc.")
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the customers date of birth
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("12/12/1998"))
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the property
            if (AnCustomer.Over18 != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //creat an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxlessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string CustomerAddress = "aaaa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a'); // should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerPaymentMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentMinplusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "aaa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerPaymentMaxlessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "aa";//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = ""; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "aaa"; //should pass
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "aaa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPaymentExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPayment = "";
            CustomerPayment = CustomerPayment.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SignUpDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //comvert the date variable to a string variable
            string SignUpDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignUpDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //comvert the date variable to a string variable
            string SignUpDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignUpDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //comvert the date variable to a string variable
            string SignUpDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignUpDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //comvert the date variable to a string variable
            string SignUpDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignUpDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //comvert the date variable to a string variable
            string SignUpDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //comvert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //comvert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //comvert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //comvert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //comvert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the resutl is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignUpDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the SignUpDtate to a non date value
            string SignUpDate = "this is not a date!";
            //invoke the method 
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the SignUpDtate to a non date value
            string DateOfBirth = "this is not a date!";
            //invoke the method 
            Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}


