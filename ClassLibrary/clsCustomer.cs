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

        public bool Find(int customerId)
        {
            mCustomerId = 1;
            mCustomerFullName = "Nirmal Vinodchandra";
            mCustomerGender = true;
            mCustomerDateOfBirth = Convert.ToDateTime("12/05/1998");
            mCustomerEmail = "nirmal@gmail.com";
            mCustomerAddress = "163 Some street";
            return true;
        }
    }
}