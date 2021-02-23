using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        clsStock AnStock = new clsStock();
        //get data from the session object 
        AnStock = (clsStock)Session["AnStock"];
        // Display the Clothes number for this Entry
        Response.Write(AnStock.ClothesNo);
        Response.Write("<br>");
        Response.Write(AnStock.ClothesDescription);
        Response.Write("<br>");
        Response.Write(AnStock.Price);
        Response.Write("<br>");
        Response.Write(AnStock.ClothesColour);
        Response.Write("<br>");
        Response.Write(AnStock.DateAdded);
        Response.Write("<br>");
        Response.Write(AnStock.Available);



    }
}