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
        //create a new intance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //captue the customerAddress etc.
        string CustomerAddress = txtAddress.Text;
        string CustomerPayment = txtPayment.Text;
        string SignUpDate = txtSignUp.Text;
        string DateOfBirth = txtSignUp.Text;
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerAddress, CustomerPayment, SignUpDate, DateOfBirth);
        if (Error == "")
        {
            AnCustomer.CustomerAddress = CustomerAddress;
            AnCustomer.CustomerPayment = CustomerPayment;
            AnCustomer.SignUpDate = Convert.ToDateTime(SignUpDate);
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnCustomer.Over18 = chkOver18.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

        }
            if (lblCustomerID = -1)
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
       else{

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