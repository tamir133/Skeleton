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

        public string Valid(string CustomerFullName, string CustomerDateOfBirth, string CustomerEmail, string CustomerAddress)
        {
            String Error = "";
            DateTime DateTemp;

            if (CustomerFullName.Length == 0)
            {
                Error = Error + "The Customer FullName may not be blank : ";
            }
            if (CustomerFullName.Length > 50)
            {
                Error = Error + "The Customer Full Name must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(CustomerDateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be above today's date : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (CustomerEmail.Length < 5)
            {
                Error = Error + "The Customer Email must not be less 5 characters : ";
            }
            if (CustomerEmail.Length > 40)
            {
                Error = Error + "The Customer Email must be less than 40 characters : ";
            }

            if (CustomerAddress.Length == 0)
            {
                Error = Error + "The Customer Address must not be blank : ";
            }
            if (CustomerAddress.Length > 50)
            {
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }

            return Error;


        }
    }
}