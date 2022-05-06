using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an istance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        //====================CustomerListOK=============================

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Nirmal Vinodchandra";
            TestItem.CustomerGender = true;            
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("12/05/1998");
            TestItem.CustomerEmail = "nirmal@gmail.com";
            TestItem.CustomerAddress = "163 Some street";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //====================ThisCustomerPropertyOK=============================

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerFullName = "Nirmal Vinodchandra";
            TestCustomer.CustomerGender = true;
            TestCustomer.CustomerDateOfBirth = Convert.ToDateTime("12/05/1998");
            TestCustomer.CustomerEmail = "nirmal@gmail.com";
            TestCustomer.CustomerAddress = "163 Some street";
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        //====================ListAndCountOK======================================

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Nirmal Vinodchandra";
            TestItem.CustomerGender = true;
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("12/05/1998");
            TestItem.CustomerEmail = "nirmal@gmail.com";
            TestItem.CustomerAddress = "163 Some street";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        //====================AddMethod=========================================================

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Nirmal Vinodchandra";
            TestItem.CustomerGender = true;
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("12/05/1998");
            TestItem.CustomerEmail = "nirmal@gmail.com";
            TestItem.CustomerAddress = "163 Some street";
            AllCustomers.ThisCustomer = TestItem;
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //====================UpdateMethod======================================================
        //====================DeleteMethod======================================================
        //====================ReportByCustomerFullNameMethod====================================
        //===================ReportByCustomerFullNameNoneFound==================================
        //====================ReportByCustomerFullNameTestDataFound=============================
    }
}
