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
            //set the private data members to test data value
            mOrderId = 21;
            mCustomerId = 12;
            mDelivered = true;
            mDescription = "Blue Shirt";
            mOrderLineId = 6;
            mQuantity = 10;
            mDateReceived = Convert.ToDateTime("25/03/2021");

            //always return true
            return true;
        }
    }
}