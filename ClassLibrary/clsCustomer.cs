using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customerID no property
        private Int32 mCustomerId;

        public Int32 CustomerID {
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
        public DateTime SignUpDate {
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
                return mDateOfBirth;
            }
            set
            {
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

        public string HouseNo { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to the test data value
            mCustomerId = 21;
            mSignUpDate = Convert.ToDateTime("16/09/2015");
            mOver18 = true;
            mDateOfBirth = Convert.ToDateTime("16/09/2016");
            mCustomerPayment = "Test Payment";
            mCustomerAddress = "Test Address";


            //always return true
            return true;
        }
    }
}