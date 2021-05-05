using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public decimal mSalary;
        public decimal Salary 
            {
            get 
            {
                return Salary;
            }
            set 
            {
              Salary = value;  
            }
        }
        public bool mStaffID;
        public bool StaffID 
        {
            get 
           {
            return mStaffID;
           }
            set 
           {
            StaffID = value;
           }
            }

        public string mStaffPosition;
        public string StaffPosition
        {
        get
        {
          return mStaffPosition; 
        } 
        set
        {
          mStaffPosition = value; 
        }
}

        public string mFirstName;
        public string FirstName
        { 
         get
         {
           return mFirstName;

         }
           set
            {
              FirstName = value; 
           }
        }


        public DateTime mDateOfBirth;
        public DateTime DateOfBirth 
        { 
        get 
        {
          return DateOfBirth;
        }
        set
        {
          DateOfBirth = value;  
        }
     }

        public DateTime mStartDate; 
        public DateTime StartDate 
        { 
        get
        {
          return StartDate;
        }
        set
        {
         StartDate = value; 
        }
    }

        public bool Find(decimal Salary )
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the address to search for 
            DB.AddParameter("@FirstName", FirstName);
            //Execute the stored procedure
            DB.Execute("sproc_tblFirstName_FilterbyFirstName");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
                {
                //Copy the data from the database to the private data members 
                mFirstName = Convert.ToInt32(DB.DataTable.Rows[0]["FirstName"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffPosition = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPosition"]);
                mDateOfBirth = Convert.ToInt32(DB.DataTable.Rows[0]["DateOfBirth"]);
                mStartDate = Convert.ToInt32(DB.DataTable.Rows[0]["StartDate"]);

                //Return that everything worked okay
                return true;
                }

            else 
            {
                //return false indicating a problem
                return false;

            }
        }
    }
    }