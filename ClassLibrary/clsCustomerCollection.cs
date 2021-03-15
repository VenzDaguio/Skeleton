using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<Customer> mCustomerList = new List<Customer>();

        public List<Customer> CustomerList
        {
            get{
                return mCustomerList;
                }

            set
            {
                mCustomerList = value;
            }
        }
       

        public Customer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                Customer AnCustomer = new Customer();
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