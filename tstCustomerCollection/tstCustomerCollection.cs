﻿using System;
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
        
    }
}