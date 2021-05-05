using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //Capture the staff ID
        String StaffID = txtStaffID.Text;
        //Capture the start date
        String StartDate = txtStartDate.Text;
        //Capture the salary
        String Salary = txtSalary.Text;
        //Capture the first name
        String FirstName = txtFirstName.Text;
        //Capture the date of birth
        String DateOfBirth = txtDateOfBirth.Text;
        //Variable to store any error messages
        String Error = " ";
        //Validate the data
        Error = AnStaff.Valid(StaffID, StartDate, Salary, FirstName, DateOfBirth);
        if (Error == "" )
        {
        //Capture the staff ID
        AnStaff.StaffID = txtStaffID.Text;
        //Capture the start date
        AnStaff.StartDate = Convert.ToDateTime(txtStartDate.Text);
        //Capture the salary
        AnStaff.Salary = txtSalary.Text;
        //Capture the first name
        AnStaff.FirstName = txtFirstName.Text;
        //Capture the Date Of Birth
        AnStaff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
}