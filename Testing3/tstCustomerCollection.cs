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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 6;
            TestItem.CustomerFullName = "Akshat Cala";
            TestItem.CustomerGender = true;
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("13/09/2001");
            TestItem.CustomerEmail = "Akshat@gmail.com";
            TestItem.CustomerAddress = "38 Quick Street";

            AllCustomers.ThisCustomer = TestItem;

            TestItem.CustomerId = PrimaryKey;
            TestItem.CustomerId = 6;
            TestItem.CustomerFullName = "DrariK Dane";
            TestItem.CustomerGender = true;
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("1/09/1994");
            TestItem.CustomerEmail = "DD@gmail.com";
            TestItem.CustomerAddress = "69 Hot street";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //====================DeleteMethod======================================================

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 6;
            TestItem.CustomerFullName = "DrariK Dane";
            TestItem.CustomerGender = true;
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("1/09/1994");
            TestItem.CustomerEmail = "DD@gmail.com";
            TestItem.CustomerAddress = "69 Hot street";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //====================ReportByCustomerFullNameMethod====================================

        [TestMethod]
        public void ReportByCustomerFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (Shoulf return all the records);
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        //===================ReportByCustomerFullNameNoneFound==================================

        [TestMethod]
        public void ReportByCustomerFullNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("Drake Sole");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        //====================ReportByCustomerFullNameTestDataFound=============================

        [TestMethod]
        public void ReportByCustomerFullNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("Nirmal Vinodchandra");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }

                if (FilteredCustomers.CustomerList[1].CustomerId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
