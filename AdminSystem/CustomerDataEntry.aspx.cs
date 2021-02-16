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
   
}