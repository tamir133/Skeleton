using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
   
        string StaffFullName = txtStaffFullName.Text;
        string StaffDOB = txtStaffDOB.Text;
        string StaffActivity = txtStaffActivity.Text;
        
        string Error = "";
        
        Error = AnStaff.Valid(StaffFullName, StaffDOB, StaffActivity);
        if (Error == "")
        {
  
            AnStaff.StaffFullName = StaffFullName;
            AnStaff.StaffGender = Convert.ToBoolean(chkMale.Checked);
            AnStaff.StaffDOB = Convert.ToDateTime(txtStaffDOB.Text);
            AnStaff.StaffActivity = StaffActivity;
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
       
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffNo;
        Boolean Found = false;
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        Found = AnStaff.Find(StaffNo);
        if(Found == true)
        {
            txtStaffActivity.Text = AnStaff.StaffActivity;
            txtStaffDOB.Text = AnStaff.StaffDOB.ToString();
            txtStaffFullName.Text = AnStaff.StaffFullName;
        }
    }
}