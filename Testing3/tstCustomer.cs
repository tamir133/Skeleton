using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerFullName = "Nirmal Vinodchandra";
        string CustomerDateOfBirth = DateTime.Now.Date.ToString();
        string CustomerEmail = "nirmal@gmail.com";        
        string CustomerAddress = "163 Some street";



        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        //====================CustomerId======================================
        [TestMethod]
        public void CustomerIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        //====================CustomerFullName================================

        [TestMethod]
        public void CustomerFullNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Nirmal Vinodchandra";
            ACustomer.CustomerFullName = TestData;
            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        //====================CustomerGender=================================

        [TestMethod]
        public void CustomerGenderOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.CustomerGender = TestData;
            Assert.AreEqual(ACustomer.CustomerGender, TestData);
        }

        //====================CustomerDateOfBirth============================

        [TestMethod]
        public void CustomerDateOfBirthOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDateOfBirth = TestData;
            Assert.AreEqual(ACustomer.CustomerDateOfBirth, TestData);
        }

        //====================CustomerEmail==================================

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "nirmal@gmail.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        //====================CustomerAddress===============================

        [TestMethod]
        public void CustomerAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "163 Some street";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        //====================FindMethod===================================

        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        //====================CustomerIdFound=============================

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

        //===============CustomerFullNameFound==============================

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

        //========================================Validation Method===============================================================

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");
        }

        //==============================CustomerFullNameValidation============================================
        [TestMethod]
        public void CustomerFullnameMinLessOne()
        {

            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "AA";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMaxLessOne()
        {

            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(49, 'B');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(25, 'C');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMaxPlusOne()
        {

            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(51, 'D');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(1000, 'E');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }


        //===============================CustomerDateOfBirthValidation======================================================================

        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-300);
            string CustomerDateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CustomerDateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string CustomerDateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CustomerDateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string CustomerDateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerDateOfBirth = "this is not a date!";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }

        //================================================CustomerEmailValidation============================================================

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "ABCD";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "ABCDE";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(39, 'C');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(20, 'D');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(41, 'E');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(300, 'F');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        //=================================CustomerAddressValidation========================================================================


        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerFullName = "";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "AB";
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAdressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'B');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'C');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'D');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(300, 'E');
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
            Assert.AreNotEqual(Error, "");

        }

    }
}
