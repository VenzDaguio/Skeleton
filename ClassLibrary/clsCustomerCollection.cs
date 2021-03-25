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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
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
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPayment", mThisCustomer.CustomerPayment);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Over18", mThisCustomer.Over18);

            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPayment", mThisCustomer.CustomerPayment);
            DB.AddParameter("@SignUpDate", mThisCustomer.SignUpDate);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Over18", mThisCustomer.Over18)


            DB.Execute("sproc_tblCustomer_Update");

        }
        public void DisplayCustomer()
        {
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ThisCustomer.Find(CustomerID);
            txtCustomerAdress.text = CustomerBook.ThisCustomer.CustomerID.ToString();
            txtCustomerPaymentInfo.text = CustomerBook.ThisCustomer.CustomerPayment();
            txtSignUpDate.text = CustomerBook.ThisCustomer.SignUpDate.ToString();
            txtDateOfBirth.text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
            chkActive.Checked = CustomerBook.ThisCustomer.Over18;
        }
    }
    
}