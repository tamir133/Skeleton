using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        private string mCustomerFullName;
        public string CustomerFullName
        {
            get
            {
                return mCustomerFullName;
            }
            set
            {
                mCustomerFullName = value;
            }
        }

        private Boolean mCustomerGender;
        public Boolean CustomerGender
        {
            get
            {
                return mCustomerGender;
            }
            set
            {
                mCustomerGender = value;
            }
        }

        private DateTime mCustomerDateOfBirth;
        public DateTime CustomerDateOfBirth
        {
            get
            {
                return mCustomerDateOfBirth;
            }
            set
            {
                mCustomerDateOfBirth = value;

            }

        }

        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");

            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mCustomerGender = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerGender"]);
                mCustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateOfBirth"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}