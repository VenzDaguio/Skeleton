using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = true;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StartDate, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateOfBirth, TestData);
        }




        [TestMethod]
        public void SalaryPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            AnStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Kiana";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void StaffPositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Member of staff";
            //assign the data to the property
            AnStaff.StaffPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffPosition, TestData);
        }

        [TestMethod]
        public void AdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = "False";
            //assign the data to the property
            AnStaff.StaffPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffPosition, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 11317;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11312;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the address no
            if (AnStaff.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11312;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.StartDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Decimal Salary = 1000.00;
            //invoke the method
            Found = AnStaff.Find(Salary);
            //check the property
            if (AnStaff.Salary != 1000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        

        [TestMethod]
        public void FirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11312;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.FirstName != "Kiana")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StartDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11315;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.StartDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11316;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.StaffPosition != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AdminFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 11316;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.Admin != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //String variable to store an error
            String Error = "";
            //Invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //Test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = ""; //this should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "Admin"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "aa"; //this should pass
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string StaffPosition = "aaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "aaaa"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "aaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPositionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //String variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "";
            StaffPosition = StaffPosition.PadRight(500, 'a'); // should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = ""; //this should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "aa"; //this should pass
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string StaffID = "aaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "aaaa"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "aaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPosition = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //String variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "";
            StaffPosition = StaffPosition.PadRight(500, 'a'); // should fail
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinplusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void FirstNameMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa";//this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "aaaaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaa"; //should pass
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //String variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //comvert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //comvert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Anstaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //comvert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //comvert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
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
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
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
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
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
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
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
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the SignUpDtate to a non date value
            string StartDate = "this is not a date!";
            //invoke the method 
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the SignUpDtate to a non date value
            string DateOfBirth = "this is not a date!";
            //invoke the method 
            Error = AnStaff.Valid(StaffPosition, StaffID, FirstName, StartDate, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





    }
}



