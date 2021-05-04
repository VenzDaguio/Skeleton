using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Over18 = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerPayment = "Siren Ocean etc.";
            TestCustomer.CustomerAddress = "Western Road";
            TestCustomer.SignUpDate = DateTime.Now.Date;
            TestCustomer.DateOfBirth = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.Over18 = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByCustomerAddressMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerAddress("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByCustomerAddressNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerAddress("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByCustomerAddressTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomers.ReportByCustomerAddress("yyy yyy");

            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCustomers.CustomerList[1].CustomerID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
