using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 StaffID = 11312;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Admin = Convert.ToBoolean(DB.DataTable.Rows[Index]["Admin"]);
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.StaffPosition = Convert.ToString(DB.DataTable.Rows[Index]["StaffPosition"]);
                AnStaff.Salary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mStaffList.Add(AnStaff);

                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }

            set
            {
                mThisStaff = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Admin", mThisStaff.Admin);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);

            return DB.Execute("sproc_tblStaff_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@Admin", mThisStaff.Admin);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);


            DB.Execute("sproc_tblStaff_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_TblStaff_FilterByFirstName");
            PopulateArray(DB);
        }


    }
}