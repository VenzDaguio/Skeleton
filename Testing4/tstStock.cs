using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]

    public class tstStock
    {
        //good test data
        //create some test data to pass to the method 
        string ClothesColour = "red";
        string ClothesDescription = "LargeShirt";
        string DateAdded = DateTime.Now.Date.ToString();
        string Price = "1";

        public object TestData { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the  data to the property
            AnStock.Active = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnStock.Active, TestData);
        }
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateStock, TestData);
        }
        [TestMethod]
        public void ClothesNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ClothesNo = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnStock.ClothesNo, TestData);



        }
        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            Decimal TestData = 1;
            AnStock.Price = TestData;
            Assert.AreEqual(AnStock.Price, TestData);
        }
        [TestMethod]
        public void ClothesColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Red";
            //assign the data to the property
            AnStock.ClothesColour = TestData;
            // test to see if the two values are the same 
            Assert.AreEqual(AnStock.ClothesColour, TestData);
        }
        [TestMethod]
        public void ClothesDescriptionPropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // create some test data to assign to the property
            string TestData = "large shirt";
            //assign data to the property
            AnStock.ClothesDescription = TestData;
            // test to see if the two values are the same 
            Assert.AreEqual(AnStock.ClothesDescription, TestData);

        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ClothesNo = 12;
            //invoke the method 
            Found = AnStock.Find(ClothesNo);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestClothesNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the Clothes no
            if (AnStock.ClothesNo != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClothesDescription()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the Clothes Description
            if (AnStock.ClothesDescription != "large shirt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestClothesColour()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the Clothes Colour
            if (AnStock.ClothesColour != "red")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPrice()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the Clothes no
            if (AnStock.Price != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Available()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the Available
            if (AnStock.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAdded()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ClothesNo = 12;
            //invoke the method
            Found = AnStock.Find(ClothesNo);
            //check the property
            if (AnStock.DateAdded != Convert.ToDateTime("16/09/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //strinf varibale to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = ""; //this should trigger an error
                                       //invoke the method 
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ClothesColourMin()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "f";//this should be ok
                                       //invoke the method 
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }
        [TestMethod]
        public void ClothesColourMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "ff"; // this should be ok
                                         //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "fffff"; // this should be ok
                                            //invoke the method 
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "ffffff"; //this should be ok
                                             // invoke the method

            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourMid()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "fff"; // this should be ok
                                          // invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "fffffffff"; // this should fail
                                                // invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesColourExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ClothesColour = "";
            ClothesColour = ClothesColour.PadRight(500, 'F'); //this should fail
                                                              //invoke the method

            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the test datetotodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string Variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the test datetotodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string Variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the test datetotodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string Variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the test datetotodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string Variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the test datetotodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string Variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            

            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ClothesDescription = "";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMin()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ClothesDescription = "f";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ClothesDescription = "ff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ClothesDescription = "ffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ClothesDescription = "fffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ClothesDescription = "ffffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClothesDescriptionMid()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ClothesDescription = "ffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription,ClothesColour,DateAdded,Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "f";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "ff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "ffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "fffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PricePlusOne()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "ffffffffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "ffff";
            //invoke the method
            Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }






























    }
}



