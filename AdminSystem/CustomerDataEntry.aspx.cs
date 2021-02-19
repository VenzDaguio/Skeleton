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
        //capture the Customer Address
        AnCustomer.CustomerAddress = txtAdress.Text;
        //capture the Customer Id
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer payment info
        AnCustomer.CustomerPayment = txtPaymentInfo.Text;
        //Captures the customers date of birth
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtBirthDate.Text);
        //Captures the customers sign up date to the system
        AnCustomer.SignUpDate = Convert.ToDateTime(txtSign.Text);
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