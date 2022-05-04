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

        //====================FindMethod=================================

        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        //====================CustomerIdFound==================

        [TestMethod]

        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //===============CustomerFullNameFound==================

        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerFullName != "Nirmal Vinodchandra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //========================CustomerGenderFound=======================

        [TestMethod]
        public void TestCustomerGenderFound()
        {

            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerGender != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //========================CustomerDateOfBirthFound=======================

        [TestMethod]
        public void TestCustomerDateOfBirthFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerDateOfBirth != Convert.ToDateTime("12/05/1998"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //========================CustomerEmailFound=======================

        [TestMethod]

        public void TestCustomerEmailFound()

        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerEmail != "nirmal@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //========================CustomerAddressFound=======================

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerAddress != "163 Some street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
