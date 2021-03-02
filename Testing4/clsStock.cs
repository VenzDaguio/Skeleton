using System;

namespace Testing4
{
    class clsStock
    {
        public clsStock()
        {
        }

        public object Active { get; internal set; }
        public DateTime DateStock { get; internal set; }
        public int ClothesNo { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public decimal Price { get; internal set; }
        public object ClothesColour { get; internal set; }
        public string ClothesDescription { get; internal set; }

        internal bool Find(int clothesNo)
        {
            throw new NotImplementedException();
        }
    }
}