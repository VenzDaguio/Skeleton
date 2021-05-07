using System;

public partial class AnStaff : System.Web.UI.Page
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

        void DisplayStaff()
        {
            clsStaffCollection StaffBook = new clsStaffCollection();
            StaffBook.ThisStaff.Find(StaffID);
            txtStaffID.txt = StaffBook.ThisStaff.StaffID.ToString();
            txtStaffPosition.txt = StaffBook.ThisStaff.StaffPosition.ToString();
            txtSalary.txt = StaffBook.ThisStaff.Salary.ToString();
            txtDateOfBirth.txt = StaffBook.ThisStaff.DateOfBirth.ToString();
            txtStartDate.txt = StaffBook.ThisStaff.StartDate.ToString();
            txtFirstName.txt = StaffBook.ThisStaff.FirstName.ToString();
            chkAdmin.chk = StaffBook.ThisStaff.Admin.ToString();
        }
    }
}
