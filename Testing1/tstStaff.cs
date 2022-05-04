using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        string StaffFullName = "Mherab Ahmed";
        string StaffDOB = DateTime.Now.Date.ToString();
        string StaffActivity = "Clocked in at 7am";

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
        //test for valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the staff class
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFullNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffFullNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "m";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffFUllNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "mmmmm";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffFUllNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "mmmmm";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFullNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffFullName = "mmmmmm";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffFullNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(500, 'm');
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffDOB = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string StaffDOB = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StaffDOB = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StaffDOB = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string StaffDOB = TestDate.ToString();
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //set the date to a non date value;
            string StaffDOB = "this is not a date!";
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffActivityExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffActivity = "";
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void StaffActivityMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(9, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void StaffActivityMin()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(10, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffActivityMinPlusOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(11, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffActivityMaxLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(49, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffActivityMaxPlusOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(51, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffActivityMid()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffActivity = "";
            StaffActivity = StaffActivity.PadRight(30, 'm');
            //invoke the method
            Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
}



