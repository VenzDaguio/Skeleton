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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        string CustomerId = txtCustomerID.Text;
        string OrderPrice = txtOrderPrice.Text;
        string Description = txtDescription.Text;
        string Quantity = txtQuantity.Text;
        string DateReceived = txtDateReceived.Text;
        string Error = "";
        Error = AnOrder.Valid(DateReceived, Description);
        if (Error == "")
        {
            AnOrder.Description = Description;
            AnOrder.DateReceived = Convert.ToDateTime(DateReceived);
            Session["AnOrder"] = AnOrder;
            Response.Write("OrdersViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        string OrderId = txtOrderID.Text;
        string CustomerId = txtCustomerID.Text;
        string DateReceived = txtDateReceived.Text;
        string OrderPrice = txtOrderPrice.Text;
        string Description = txtDescription.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = AnOrder.Valid(Description, DateReceived);
        if (Error == "")
        {
            AnOrder.OrderId = Convert.ToInt32(OrderId);
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.DateReceived = Convert.ToDateTime(DateReceived);
            AnOrder.OrderPrice = Convert.ToInt32(OrderPrice);
            AnOrder.Description = Description;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.Delivered = chkDelivered.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result to find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderID.Text);
        //find the record   
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = AnOrder.CustomerId.ToString();
            txtDateReceived.Text = AnOrder.DateReceived.ToString();
            txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
            txtDescription.Text = AnOrder.Description;
            txtQuantity.Text = AnOrder.Quantity.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}