using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerTable = new clsCustomerCollection();
        CustomerTable.ThisCustomer.Find(CustomerID);
        CustomerTable.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}