using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string CustomerAddress;
        public object HouseNo;

        public DateTime SignUpDate { get; set; }
        public string CustomerPayment { get; set; }
        public string AccountInfo { get; set; }
        public int CustomerID { get; set; }
    }
}