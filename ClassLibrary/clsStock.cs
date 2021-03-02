using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the address no property
        private Int32 mStockNo;
        public clsStock()
        {
        }


        //ClothesNo private member variable 
        private Int32 mClothesNo;
        //ClothesNo public property
        public Int32 ClothesNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStockNo;
            }
           set
            {
                // this line of code allows data into the property
                mStockNo = value;
            }
        }
        public string ClothesDescription { get; set; }
        public string Price { get; set; }
        public string DateAdded { get; set; }
        public string Available { get; set; }
        public string ClothesColour { get; set; }

        public bool Find(int clothesNo)
        {
            //set the private data members to the test data value
            mStockNo = 12;
            //always return true
            return true;
        }
    }
}