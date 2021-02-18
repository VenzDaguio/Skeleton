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










     }
}


