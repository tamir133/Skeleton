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
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerGender", mThisCustomer.CustomerGender);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerGender", mThisCustomer.CustomerGender);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullName(string CustomerFullName)
        {
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@CustomerFullName", CustomerFullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
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