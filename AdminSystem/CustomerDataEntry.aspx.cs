using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }

    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerID);

        txtCustomerID.Text = Customers.ThisCustomer.CustomerID.ToString();
        txtSignUp.Text = Customers.ThisCustomer.SignUpDate.ToString();
        txtBirthDate.Text = Customers.ThisCustomer.DateOfBirth.ToString();
        txtPayment.Text = Customers.ThisCustomer.CustomerPayment;
        txtAddress.Text = Customers.ThisCustomer.CustomerAddress;
        chkOver18.Checked = Customers.ThisCustomer.Over18;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
      
        clsCustomer AnCustomer = new clsCustomer();

        string CustomerAddress = txtAddress.Text;
        string CustomerPayment = txtPayment.Text;
        string SignUpDate = txtSignUp.Text;
        string DateOfBirth = txtBirthDate.Text;
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
        if (Error == "")
        {
            AnCustomer.CustomerID = CustomerID;
            AnCustomer.CustomerAddress = CustomerAddress;
            AnCustomer.CustomerPayment = CustomerPayment;
            AnCustomer.SignUpDate = Convert.ToDateTime(SignUpDate);
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnCustomer.Over18 = chkOver18.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }

            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        
        clsCustomer AnCustomer = new clsCustomer();
       
        Int32 CustomerID;
        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text); 
        Found = AnCustomer.Find(CustomerID);

        if (Found == true)
        {
            //display the values of the properties in the form
            txtSignUp.Text = AnCustomer.SignUpDate.ToString();
            txtBirthDate.Text = AnCustomer.DateOfBirth.ToString();
            txtPayment.Text = AnCustomer.CustomerPayment;
            txtAddress.Text = AnCustomer.CustomerAddress;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsCustomerCollection OrderList = new clsCustomerCollection();
        Response.Redirect("CustomerList.aspx");

    }
}