using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {

        public int CustomerId;
        public decimal OrderPrice;
        public bool Delivered;
        public string Description;
        public int OrderLineId;
        public int Quantity;
        public DateTime DataReceived;

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
            
        public bool Find(int OrderId)
        {
            //set the private data members to test data value
            mOrderId = 12;
            //always return true
            return true;
        }
    }
}