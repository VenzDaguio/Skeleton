using System.Collections.Generic;
using ClassLibrary;

namespace Testing1
{
    internal class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList { get; internal set; }
        public int Count { get; internal set; }
        public clsOrder ThisOrder { get; internal set; }
    }
}