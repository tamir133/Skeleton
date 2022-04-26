using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active
        {
            get;
            set;
        }
        public DateTime DateAdded { get; set; }
        public string StaffNo { get; set; }
        public string StaffFullName { get; set; }
        public bool StaffGender { get; set; }
        public string CustomerNo { get; set; }
    }
}