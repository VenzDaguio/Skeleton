using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByDescription(string Description)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Description", Description);
            DB.Execute("sproc_TblOrder_FilterByDescription");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Delivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivered"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnOrder.OrderLineId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineId"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.DateReceived = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateReceived"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}