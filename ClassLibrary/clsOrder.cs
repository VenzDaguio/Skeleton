using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId;
        public int CustomerId;
        public decimal OrderPrice;
        public bool Delivered;
        public string Description;
        public int OrderLineId;
        public int Quantity;
        public DateTime DataReceived;
    }
}