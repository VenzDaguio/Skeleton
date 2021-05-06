using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblClothes_SelectAll");
            PopulateArray(DB);
        }

         void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
              clsStock AnStock = new clsStock();
                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStock.ClothesNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ClothesNo"]);
                AnStock.ClothesDescription = Convert.ToString(DB.DataTable.Rows[Index]["ClothesDescription"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.ClothesColour = Convert.ToString(DB.DataTable.Rows[Index]["ClothesColour"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mStockList.Add(AnStock);
                
                Index++;
            }
        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }

            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }

            set
            {
                mThisStock = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@ClothesColour", mThisStock.ClothesColour);
            DB.AddParameter("@ClothesDescription", mThisStock.ClothesDescription);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);

            return DB.Execute("sproc_tblClothes_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClothesNo", mThisStock.ClothesNo);
            DB.AddParameter("@ClothesDescription", mThisStock.ClothesDescription);
            DB.AddParameter("@ClothesColour", mThisStock.ClothesColour);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);


            DB.Execute("sproc_tblClothes_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClothesNo", mThisStock.ClothesNo);
            DB.Execute("sproc_tblClothes_Delete");
        }

        public void ReportByClothesDescription(string ClothesDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClothesDescription", ClothesDescription);
            DB.Execute("sproc_TblClothes_FilterByClothesDescription");
            PopulateArray(DB);
        }

        
    }
}