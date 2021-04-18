using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            DB.AddParameter("@Description", mThisOrder.Description);
            DB.AddParameter("@OrderLineId", mThisOrder.OrderLineId);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@DateReceived", mThisOrder.DateReceived);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            DB.AddParameter("@Description", mThisOrder.Description);
            DB.AddParameter("@OrderLineId", mThisOrder.OrderLineId);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@DateReceived", mThisOrder.DateReceived);

            DB.Execute("sproc_tblOrder_Update");
        }
    }
}