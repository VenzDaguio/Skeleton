using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customerID no property
        private Int32 mCustomerId;

        public Int32 CustomerID
        {
            get
            { //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        //SingUpDate private member variable
        private DateTime mSignUpDate;
        public DateTime SignUpDate
        {
            get
            {
                return mSignUpDate;
            }
            set
            {
                mSignUpDate = value;
            }
        }
        //private data member for Over18
        private Boolean mOver18;
        //public property for active
        public bool Over18
        {
            get
            {
                //return the private data
                return mOver18;
            }
            set
            {
                //set the private data
                mOver18 = value;
            }
        }
        //DateOfBirth private member variable
        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }
        //private data member for CustomerAddress
        private string mCustomerAddress;
        //public property for CustomerAddress
        public string CustomerAddress
        {
            get
            {
                //return private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }
        private string mCustomerPayment;
        public string CustomerPayment
        {
            get
            {
                //return private data
                return mCustomerPayment;
            }
            set
            {
                //set the private data
                mCustomerPayment = value;
            }
        }


        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerPayment = Convert.ToString(DB.DataTable.Rows[0]["CustomerPayment"]);
                mSignUpDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SignUpDate"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicatin a problem
                return false;
            }
        }

        public string Valid(
                    string customerAddress,
                    string customerPayment,
                    string signUpDate,
                    string dateOfBirth)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the customer address is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank:";
            }
            //if the customer address is greater than 6 characters
            if (customerAddress.Length > 20)
            {
                //record the error
                Error = Error + "The customer address must be lesss than 20 characters:";
            }
            //if the customer payment is blank
            if (customerPayment.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank:";
            }
            //if the customer address is greater than 50 charcaters
            if (customerPayment.Length > 50)
            {
                //record the error
                Error = Error + "The customer address must be lesss than 50 characters:";
            }
            try
            {
                //copy the SigpUpdate value to the dateTemp variable
                DateTemp = Convert.ToDateTime(signUpDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past:";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future:";
                }
            }
            catch
            {
                Error = Error + "The date was not a vaile date:";
            }
            try
            {
                //copy the SigpUpdate value to the dateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past:";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future:";
                }
            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date:";
            }

            //return any error messages
            return Error;
        }
    }
}
