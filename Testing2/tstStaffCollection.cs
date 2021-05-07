using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collection.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        
        //private data member for the list 
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisAddress
        clsStaff mThisStaff = new clsStaff();
        //public property for the list 
        public clsStaff ThisStaff 
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //we shall worry about this later 
            }
        }

        

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.isNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Admin";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Nelson";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see the value is the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void CountProperty()
        {
            //Create the instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test for the property
            Int32 someCount = 2;
            //assign the data to the prperty
            AllStaff.Count = someCount;
            //Test to see the values are the same 
            Assert.AreEqual(AllStaff.Count, someCount);
        }

        [TestMethod]
        public void ThisStaffProperty()
        {
            //Create the instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Member of staff";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Kenneth";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Admin";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Nelson";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see the value is the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        
        //Constructor for the class
        public clsStaffCollection()
        {
            //Create the items of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Admin";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Nelson";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //add the item to the item list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            //set its properties 
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Member of staff";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Kenneth";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //add the item to the item list 
            mStaffList.Add(TestItem);
        }

        [TestMethod]
        public void addMethod()
        {
         //Create the instance of the class we want to create
         clsStaffCollection AllStaff = new clsStaffCollection();
         //create the item of the test data
         clsStaff TestItem = new clsStaff();
         //var to store the primary key 
         Int32 PrimaryKey = 0;
         //set its properties
         TestItem.Admin = false;
         TestItem.StaffID = 11312;
         TestItem.StaffPosition = "Admin";
         TestItem.Salary = 1000.00;
         TestItem.FirstName = "Nelson";
         TestItem.DateOfBirth = "07/09/2002";
         TestItem.StartDate = "21/04/2021";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Add();
            //Set primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.areEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethod()
        {
            //Create the instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Admin";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Nelson";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Add();
            //Set primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //set its properties
            TestItem.Admin = false;
            TestItem.StaffID = 11312;
            TestItem.StaffPosition = "Admin";
            TestItem.Salary = 1000.00;
            TestItem.FirstName = "Nelson";
            TestItem.DateOfBirth = "07/09/2002";
            TestItem.StartDate = "21/04/2021";
            //set the record based on the new data
            AllStaff.ThisStaff = TestItem;
            //Update the record
            AllStaff.Update();
            //Find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.areEqual(AllStaff.ThisStaff, TestItem);

        }
        

        [TestMethod]
        public void DeleteMethod ()
        {
        clsStaffCollection AllStaff = new clsStaffCollection();
        clsStaff TestItem = new clsStaff();
        Int32 PrimaryKey = 0;

            TestItem.Admin = true;
            TestItem.StaffID = 11313;
            TestItem.FirstName = "Kiana";
            TestItem.StaffPosition = "Admin";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
             Assert.IsFalse(Found);
        }
        
        }

    [TestMethod]
    public void ReportByFirstNameMethodOK()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        clsStaffCollection FilteredStaff = new clsStaffCollection();
        FilteredStaff.ReportByFirstName("");
        Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
    }

    [TestMethod]
    public void ReportByFirstNameNoneFound()
    {
        clsStaffCollection FilteredStaff = new clsStaffCollection();
        FilteredStaff.ReportByFirstName("abc");
        Assert.AreEqual(0, FilteredStaff.Count);
    }
}


