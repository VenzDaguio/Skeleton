using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtAvailable { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance clsStock
        clsStock AnStock = new clsStock();
        // capture the ClothesDescription
        AnStock.ClothesDescription = txtClothesDescription.Text;
        // store the Stock in the session object
        Session["AnStock"] = AnStock;
        //Navigate to the viewer page 
        Response.Redirect("StockViewer.aspx");



    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //capture the clothes colour
        string ClothesColour = txtClothesColour.Text;
        //capture the ClothesDescription
        string ClothesDescription = txtClothesDescription.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        //validate the error
        Error = AnStock.Valid(ClothesDescription, ClothesColour, DateAdded, Price);


        if (Error == "")
        {
            //capture clothes Description
            AnStock.ClothesDescription = ClothesDescription;
            //capture clothes colour
            AnStock.ClothesColour = ClothesColour;
            
            //capture dateadded
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            Session["AnStock"] = AnStock;
            //redirect to viewer page
            Response.Write("StockViewer.aspx");
            

        }
        else
        {
            //display the error message
            iblError.Text = Error;
        }
}

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key 
        Int32 ClothesNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        ClothesNo = Convert.ToInt32(txtClothesNo.Text);
        //find the record
        Found = AnStock.Find(ClothesNo);
        //if found
        if (Found == true)
        {
            //dsiplay the values of the properties in the form 
            txtClothesNo.Text = AnStock.ClothesNO;
            txtClothesDescription.Text = AnStock.ClothesDescription;
            txtPrice.Text = AnStock.Price.ToString();
            txtClothesColour.Text = AnStock.ClothesColour.ToString();
            txtDateAdded.Text = AnStock.DateAdded.ToString();



        }
    }
}
