using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace tstCustomerCollection
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
            //create an instance of the class we want to create
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

            //test to see that the result is correct
            Assert.AreNotEqual(AllCustomers.ThisCustomer, TestItem);
        }
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;
            TestItem.Over18 = true;
            TestItem.CustomerPayment = "Siren Ocean etc.";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;

            TestItem.Over18 = false;
            TestItem.CustomerPayment = "Siren Ocean etc";
            TestItem.CustomerAddress = "Western Road";
            TestItem.SignUpDate = DateTime.Now.Date;
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllCustomer.ThisCustomer = TestItem;
            AllCustomer.Update();
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
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
        public void RepostByCustomerAddressMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByCustomerAddress("yyy yyy");
            if(Filteredcustomers.Count == 2)
            {
                if(FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[1].CustomerID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
