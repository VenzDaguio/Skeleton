using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 ClothesNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ClothesNo = Convert.ToInt32(Session["ClothesNo"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ThisStock.Find(ClothesNo);
        Stocks.Delete();
        Response.Redirect("StockList.aspx");

    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}