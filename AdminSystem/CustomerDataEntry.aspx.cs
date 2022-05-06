using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
   Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
       CustomerId = Convert.ToInt32(Session["CustomerId"]);
          if (IsPostBack == false)
          {
             if (CustomerId != -1)
             {
                DisplayCustomers();
             }
          }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ThisCustomer.Find(CustomerId);
        txtCustomerId.Text = ACustomer.ThisCustomer.CustomerId.ToString();
        txtCustomerFullName.Text = ACustomer.ThisCustomer.CustomerFullName;
        ddlCustomerGender.Text = ACustomer.ThisCustomer.CustomerGender.ToString();
        txtCustomerDateOfBirth.Text = ACustomer.ThisCustomer.CustomerDateOfBirth.ToString();
        txtCustomerEmail.Text = ACustomer.ThisCustomer.CustomerEmail;       
        txtCustomerAddress.Text = ACustomer.ThisCustomer.CustomerAddress;

    }

    

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = ACustomer.Find(CustomerId);

        if (Found == true)
        {

            lblError.Text = "";
            txtCustomerFullName.Text = ACustomer.CustomerFullName;
            ddlCustomerGender.SelectedValue = ACustomer.CustomerGender.ToString();
            ddlCustomerGender.Text = ACustomer.CustomerGender.ToString();
            txtCustomerDateOfBirth.Text = ACustomer.CustomerDateOfBirth.ToString();
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;

        }
        else
        {
            txtCustomerFullName.Text = "";
            txtCustomerDateOfBirth.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerAddress.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }
    
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string CustomerFullName = txtCustomerFullName.Text;
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string Error = "";
        


        Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerEmail, CustomerAddress);
        
        if (Error == "")
        {
            ACustomer.CustomerId = CustomerId;
            ACustomer.CustomerFullName = CustomerFullName;
            ACustomer.CustomerGender = Convert.ToBoolean(ddlCustomerGender.SelectedValue);
            ACustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
            ACustomer.CustomerEmail = CustomerEmail;
            ACustomer.CustomerAddress = CustomerAddress;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");

        }
        lblError.Text = Error;
    }
}
