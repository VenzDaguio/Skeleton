using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
  
     public class tstStock
    {
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
            Boolean Testdata = true;
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
            Assert.AreEqual(AnClothes.Price, TestData);
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
            Found = AnClothes.Find(ClothesNo);
            //check the Clothes no
            if (AnClothes. ClothesNo != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }











     }
}


