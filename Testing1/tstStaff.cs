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
            AnStaff.StaffDOB = TestData;
            Assert.AreEqual(AnStaff.StaffDOB, TestData);
        }
        [TestMethod]
        public void StaffNoOK()
        {
            //Testing Staff No property
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 21;
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
        public void StaffActivityOK()
        {
            //Testing Staff Activity
            clsStaff AnStaff = new clsStaff();
            string TestData = "Clocked in at 7am";
            AnStaff.StaffActivity = TestData;
            Assert.AreEqual(AnStaff.StaffActivity, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance for staff class
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data with the method
            Int32 StaffNo = 1;
            //invoke the methods
            Found = AnStaff.Find(StaffNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffNoFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffFullNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffFullName != "Mherab Ahmed")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffGenderFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffGender != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffDOB != Convert.ToDateTime("21/10/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffActivityFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 1;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffActivity != "Clocked in at 7am")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
