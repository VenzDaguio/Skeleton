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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the Customer Id
        AnCustomer.CustomerAddress = txtAdress.Text;
        //AnCustomer.CustomerID = txtCustomerID.int32;
        AnCustomer.CustomerPayment = txtPaymentInfo.Text;
        //AnCustomer.DateOfBirth = txtBirthDate.Text;
        //AnCustomer.SignUpDate = txtSign.Text;
        //Store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = AnCustomer.CustomerAddress;
            txtPayment.Text = AnCustomer.CustomerPayment;
            txtSignUp.Text = AnCustomer.SignUpDate.ToString();
            txtBirthDate.Text = AnCustomer.DateOfBirth.ToString();




        }
    }
}