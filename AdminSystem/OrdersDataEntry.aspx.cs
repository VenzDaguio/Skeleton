using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId; 
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderId);
        txtOrderID.Text = Orders.ThisOrder.OrderId.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerId.ToString();
        txtDateReceived.Text = Orders.ThisOrder.DateReceived.ToString();
        txtOrderPrice.Text = Orders.ThisOrder.OrderPrice.ToString();
        txtDescription.Text = Orders.ThisOrder.Description;
        txtQuantity.Text = Orders.ThisOrder.Quantity.ToString();
        chkDelivered.Checked = Orders.ThisOrder.Delivered;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        //string OrderId = txtOrderID.Text;
        string CustomerId = txtCustomerID.Text;
        string DateReceived = txtDateReceived.Text;
        string OrderPrice = txtOrderPrice.Text;
        string Description = txtDescription.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = AnOrder.Valid(Description, DateReceived, CustomerId, OrderPrice, Quantity);
        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.DateReceived = Convert.ToDateTime(DateReceived);
            AnOrder.OrderPrice = Convert.ToDecimal(OrderPrice);
            AnOrder.Description = Description;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.Delivered = chkDelivered.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }

            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

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
            lblError.Text = "";
        }

        if (Found == false)
        {
            lblError.Text = "Order ID not found";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        Response.Redirect("OrdersList.aspx");
        
    }
}

