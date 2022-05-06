using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_FrameWork
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cretae
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            TestItem.StaffNo = 1;
            TestItem.StaffFullName = "Mherab Ahmed   ";
            TestItem.StaffGender = true;
            TestItem.StaffDOB = Convert.ToDateTime("07/05/2002");
            TestItem.StaffActivity = "Clocked in at 7am";

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffNo = 1;
            TestStaff.StaffFullName = "Mherab Ahmed ";
            TestStaff.StaffGender = true;
            TestStaff.StaffDOB = Convert.ToDateTime("07/05/2002");
            TestStaff.StaffActivity = "Clocked in at 7am";
            
        }
        [TestMethod]
        public void ListAndCountOk()
        {

            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();

            TestItem.StaffNo = 1;
            TestItem.StaffFullName = "Mherab Ahmed ";
            TestItem.StaffGender = true;
            TestItem.StaffDOB = Convert.ToDateTime("07/05/2002");
            TestItem.StaffActvity = "Admin";
            

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

