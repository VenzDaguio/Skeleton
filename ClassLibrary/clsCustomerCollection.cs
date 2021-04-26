using System;
using System.Collections.Generic;

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
        public clsCustomer ThisCustomer
        {
            get
            {
               return ThisCustomer;
            }

            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelecteAll");
            PopulateArray(DB);

        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPayment);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Over18", mThisCustomer.Over18);

            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPayment);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Over18", mThisCustomer.Over18);


            DB.Execute("sproc_tblCustomer_Update");

        }
        public void DisplayCustomer()
        {
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ThisCustomer.Find(CustomerID);
            txtCustomerAdress.text = CustomerBook.ThisCustomer.CustomerID.ToString();
            txtCustomerPaymentInfo.text = CustomerBook.ThisCustomer.CustomerPayment
                ();
            txtSignUpDate.text = CustomerBook.ThisCustomer.SignUpDate.ToString();
            txtDateOfBirth.text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
            chkActive.Checked = CustomerBook.ThisCustomer.Over18;
        }
        public void Delete()
        {
            clsCustomerCollection DB = new clsCustomerCollection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void ReportByCustomerAddress(string CustomerAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerAddress", CustomerAddress);
            DB.Execute("sproc_tblCustomer_FilterByCustomerAddress");
            PopulateArray(DB);
        }
        void PopulateArray(clsCustomerCollection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.CustomerPayment = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPaymentInfo"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.SignUpDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SignUpDate"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);

                mCustomerList.Add(AnCustomer);
                Index++;
            }
        }
    }
    
}