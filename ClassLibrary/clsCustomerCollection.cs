using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }

            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }

            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }

            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerGender = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerGender"]);
                ACustomer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}