using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnStock : System.Web.UI.Page
{
    Int32 ClothesNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ClothesNo = Convert.ToInt32(Session["ClothesNo"]);
        if(IsPostBack== false)
        {
            if (ClothesNo != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection StockBook = clsStockCollection();
        StockBook.ThisStock.Find(ClothesNo);
        txtClothesNo.Text = StockBook.ThisStock.ClothesNo.ToString();
        txtClothesDescription.Text = StockBook.ThisStock.ClothesDescription;
        txtClothesColour.Text = StockBook.ThisStock.ClothesColour;



    }
}