using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void StaffFullNameOK()
        {
            //Testing Staff Full Name property
            clsStaff AnStaff = new clsStaff();
            string TestData = "Mherab Ahmed";
            AnStaff.StaffFullName = TestData;
            Assert.AreEqual(AnStaff.StaffFullName, TestData);


        }

        [TestMethod]
        public void StaffDOBOK()
        {
            //Testing Staff DOB property
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateAdded = TestData;
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }
        [TestMethod]
        public void StaffNoOK()
        {
            //Testing Staff No property
            clsStaff AnStaff = new clsStaff();
            string TestData = "21";
            AnStaff.StaffNo = TestData;
            Assert.AreEqual(AnStaff.StaffNo, TestData);

        }
        [TestMethod]
        public void StaffGenderOK()
        {
            //Testing Staff Gender property
            clsStaff AnStaff = new clsStaff();
            Boolean TestData = true;
            AnStaff.StaffGender = TestData;
            Assert.AreEqual(AnStaff.StaffGender, TestData);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            //Testing Customer No property
            clsStaff AnStaff = new clsStaff();
            string TestData = "16";
            AnStaff.CustomerNo = TestData;
            Assert.AreEqual(AnStaff.CustomerNo, TestData);

        }
        [TestMethod]
        public void StaffActivityOK()
        {
            //Testing Staff Activity
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateAdded = TestData;
            Assert.AreEqual(AnStaff.DateAdded, TestData);

        }







    }
}
