using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //lstCustomers.DataSource = Customers.CustomerList;

        //lstCustomers.DataValueField = "CustomerID";
        //lstCustomers.DataTextField = "PostCode";
        //lstCustomers.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("AnCustomer.aspx");
    }
    protected void btnEdit_Click(object sebder, EventArgs e)
    {
        Int32 CustomerID;
        if(lstCustomerList.SelectedIndex != - 1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("AnCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please selecte a record to delete from the list";
        }
    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByCustomerAddress(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValuefield = "CustomerID";
        lstCustomerList.DataTextfield = "PostCode";
        lstCustomerList.DataBind();
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByCustomerAddress("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "Customer Address";
        lstCustomerList.DataBind();
    }
}