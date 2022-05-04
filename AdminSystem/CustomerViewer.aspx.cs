using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.CustomerId + "<br>");
        Response.Write(ACustomer.CustomerFullName + "<br>");
        Response.Write(ACustomer.CustomerGender + "<br>");
        Response.Write(ACustomer.CustomerDateOfBirth + "<br>");
        Response.Write(ACustomer.CustomerEmail + "<br>");
        Response.Write(ACustomer.CustomerAddress + "<br>");
    }
}