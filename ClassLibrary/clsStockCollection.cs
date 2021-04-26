using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

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
                return ThisStock;
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
    }
}
   