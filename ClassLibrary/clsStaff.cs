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
            //set the private data members to the test data value
            mSalary = 1000;
            mStaffID = "123";
            mStaffPosition = "Member";
            mFirstName= "Kiana";
            mDateOfBirth = Convert.ToDateTime("26/05/2015");
            mStartDate = Convert.ToDateTime("26/05/2015");
            //always return true
            return true;
}
        }
    }
