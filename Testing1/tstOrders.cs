using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
        public void TestMethod1()
        {
        }
    }
}
