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
        //Variable to store the primary key 
        Int32 StaffID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //Find the record
        Found = AnStaff.Find(StaffID);
        //if found
        if(Found == true)
        {
            // display the values of the properties in the form
            txtStartDate.Text = AnStaff.StartDate;
            txtSalary.Text = AnStaff.Salary;
            txtFirstName.Text = AnStaff.FirstName;
            txtDateOfBirth.Text = AnStaff.DateOfBirth;
            chkAdmin.Checked = AnStaff.Admin;
            chkMemberOfStaff.Checked = AnStaff.MemberOfStaff;
        }


    }
}