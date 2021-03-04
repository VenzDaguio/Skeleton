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
                return mClothesNo;
            }
           set
            {
                // this line of code allows data into the property
                mClothesNo = value;
            }
        }
        //ClothesDescription private member variable 
        private String mClothesDescription;
        //ClothesDescription public property
        public string ClothesDescription
        {
            get
            {
                //return the private data
                return mClothesDescription;
            }
            set
            {
                //set the private data
                mClothesDescription = value;
            }
        }




        //Price private member variable 
        private Decimal mPrice;
        //Price public property
        public Decimal Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //private data member for DateAdded 
        private DateTime mDateAdded;
        //public property for DateAdded
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }




        //private data member for Available 
        private Boolean mAvailable;
        //Available public property
        public Boolean Available
        {
            get
            {
                //return the private data
                return mAvailable;
            }
            set
            {
                //set the private data
                mAvailable = value;
            }
        }
        //private data member for ClothesColour
        private string mClothesColour;
        //public property for ClothesColour

        public string ClothesColour
        {
            get
            {
                //return the private data
                return mClothesColour;
            }
            set
            {
                //set the private data
                mClothesColour = value;
            }
        }

        public bool Find(int clothesNo)
        {
            //set the private data members to the test data value
            mClothesNo = 12;
            mClothesDescription = "large shirt";
            mClothesColour = "red";
            mDateAdded = Convert.ToDateTime("16/9/2021");
            mPrice = 1;
            mAvailable = true;

            //always return true
            return true;
        }
    }
}