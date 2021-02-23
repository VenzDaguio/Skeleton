using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public string ClothesNo { get; set; }
        public string ClothesDescription { get; set; }
        public string Price { get; set; }
        public string DateAdded { get; set; }
        public string Available { get; set; }
        public string ClothesColour { get; set; }

        public bool Find(int clothesNo)
        {
            throw new NotImplementedException();
        }
    }
}