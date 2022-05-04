using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        //====================CustomerId=============================
        [TestMethod]
        public void CustomerIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        //====================CustomerFullName=============================

        [TestMethod]
        public void CustomerFullNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Nirmal Vinodchandra";
            ACustomer.CustomerFullName = TestData;
            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        //====================CustomerGender=============================

        [TestMethod]
        public void CustomerGenderOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.CustomerGender = TestData;
            Assert.AreEqual(ACustomer.CustomerGender, TestData);
        }

        //====================CustomerDateOfBirth=============================

        [TestMethod]
        public void CustomerDateOfBirthOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDateOfBirth = TestData;
            Assert.AreEqual(ACustomer.CustomerDateOfBirth, TestData);
        }

        //====================CustomerEmail===================================

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "nirmal@gmail.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        //====================CustomerAddress=================================

        [TestMethod]
        public void CustomerAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "163 Some street";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
    }
}
