using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the address no property
        private Int32 mStock;
        
        


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

        public string ClothesNO { get; set; }

        public bool Find(int clothesNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for 
            DB.Execute("sproc_tblClothes_FilterByClothesNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mClothesNo = Convert.ToInt32(DB.DataTable.Rows[0]["ClothesNo"]);
                mClothesDescription = Convert.ToString(DB.DataTable.Rows[0]["ClothesDescription"]);
                mClothesColour = Convert.ToString(DB.DataTable.Rows[0]["ClothesColour"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked Ok
                return true;




            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
        public string Valid(string ClothesColour, string DateAdded, string Price , string ClothesDescription)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary varibale to store values
            DateTime DateTemp;
            //if the ClothesColour is blank
            if (ClothesColour.Length == 0)
            {
                //record the error
                Error = Error + "The clothesColour may not be blank : ";

            }
            //if ClothesColour is greater than 9characters
            if (ClothesColour.Length > 9)
            {
                //record the error
                Error = Error + "ClothesColour must be lass than 9 characters : ";
            }
            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if(DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past:";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }


            }
            catch
            {
                //record the error 
                Error = Error + "the date was not a valid date:";

            }
            return Error;
            
            

            
            
            
            
        }
            
            





    }
}