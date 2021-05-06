using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
            }
        }
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
               
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.SignUpDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SignUpDate"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerPayment = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPaymentInfo"]);
                
                mCustomerList.Add(AnCustomer);
                
                Index++;
            }
        }
        public int Add()
        { 
            clsDataConnection DB = new clsDataConnection();
           
            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPayment);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@Over18", mThisCustomer.Over18);

            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPayment);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@Over18", mThisCustomer.Over18);
            
            DB.Execute("sproc_tblCustomer_Update");
        }
        public void ReportByCustomerAddress(string CustomerAddress)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerAddress", CustomerAddress);

            DB.Execute("sproc_tblCustomer_FilterByCustomerAddress");
            PopulateArray(DB);
        }


    }
}