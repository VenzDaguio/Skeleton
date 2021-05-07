using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaff();
            }

        }
    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ThisStaff.Find(StaffID);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffPosition";
        lstStaffList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        StaffPosition.ReportByStaffPosition(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffPosition";
        lstStaffList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Customers.ReportByCustomerAddress("");
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffPosition";
        lstStaffList.DataBind();
    }

}