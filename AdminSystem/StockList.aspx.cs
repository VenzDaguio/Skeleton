using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //if this is the first time the page is dsiplayed
        if (IsPostBack == false)
        {
           
            
                //update the list box
                DisplayStocks();

            
            
        }

    }
    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStocks.DataSource = Stocks.StockList;
        lstStocks.DataValueField = "ClothesNo";
        lstStocks.DataTextField = "ClothesDescription";
        lstStocks.DataBind();

    }

}