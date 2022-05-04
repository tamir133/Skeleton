using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffNo;
        private DateTime mDOB;
        private string mStaffFullName;
        private bool mStaffGender;
        private string mStaffActivity;
        public DateTime StaffDOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        public Int32 StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }
        public string StaffFullName
        {
            get
            {
                return mStaffFullName;
            }
            set
            {
                mStaffFullName = value;
            }

        }
        public bool StaffGender
        {
            get
            {
                return mStaffGender;
            }
            set
            {
                mStaffGender = value;
            }
        }
        public string StaffActivity
        {
            get
            {
                return mStaffActivity;
            }
            set
            {
                mStaffActivity = value;
            }
        }

        public bool Find(int StaffNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", StaffNo);
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            if(DB.Count == 1)
            {
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffActivity = Convert.ToString(DB.DataTable.Rows[0]["StaffActivity"]);
                mStaffGender = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffGender"]);
                mStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["StaffFullName"]);
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string StaffFullName, string StaffDOB, string StaffActivity)
        {
            String Error = "";
            DateTime DateTemp;
            if (StaffFullName.Length == 0)
            {
                Error = Error + "The Staff Name may not be blank : ";
            }
            if (StaffFullName.Length > 21)
            {
                Error = Error + "The Staff Name must be less than 21 characters :";
            }
            try
            {
                DateTemp = Convert.ToDateTime(StaffDOB);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date is not valid : ";
            }

            //is the staff activity blank
            if (StaffActivity.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Activity may not be less than 0 characters :";
            }
            //if the staff activity is too long
            if (StaffActivity.Length > 50)
            {
                //record the error
                Error = Error + "The Staff activity must be less than 51 characters :";
            }
            //return any error messages
            return Error;


        }
    }
}