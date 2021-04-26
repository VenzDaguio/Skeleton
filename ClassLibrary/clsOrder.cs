using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {
        //orderId private member variable
        private Int32 mOrderId;
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        private Decimal mOrderPrice;
        public Decimal OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }

        private bool mDelivered;
        public bool Delivered
        {
            get
            {
                return mDelivered;
            }
            set
            {
                mDelivered = value;
            }
        }

        private string mDescription;
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        private int mOrderLineId;
        public int OrderLineId
        {
            get
            {
                return mOrderLineId;
            }
            set
            {
                mOrderLineId = value;
            }
        }

        private int mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private DateTime mDateReceived;
        public DateTime DateReceived
        {
            get
            {
                return mDateReceived;
            }
            set
            {
                mDateReceived = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data collection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDateReceived = Convert.ToDateTime(DB.DataTable.Rows[0]["DateReceived"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string description, string dateReceived, string customerid, string orderprice, string quantity)
        {
            String Error = "";
            DateTime DateTemp;
            if (description.Length == 0)
            {
                Error = Error + "The description may not be blank: ";
            }
            if (description.Length > 50)
            {
                Error = Error + "The description must be less than 50 characters: ";
            }
            if (customerid.Length == 0)
            {
                Error = Error + "The Customer ID may not be blank: ";
            }
            if (orderprice.Length == 0)
            {
                Error = Error + "The Order Price may not be blank: ";
            }
            if (quantity.Length == 0)
            {
                Error = Error + "The Quantity may not be blank: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateReceived);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }
            return Error;
        }
    }
}




