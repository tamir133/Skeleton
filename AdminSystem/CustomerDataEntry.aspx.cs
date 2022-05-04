﻿using System;
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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        ACustomer.CustomerFullName = txtCustomerFullName.Text;
        ACustomer.CustomerGender = Convert.ToBoolean(ddlCustomerGender.SelectedValue);
        ACustomer.CustomerDateOfBirth = Convert.ToDateTime(txtCustomerDateOfBirth.Text);
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}