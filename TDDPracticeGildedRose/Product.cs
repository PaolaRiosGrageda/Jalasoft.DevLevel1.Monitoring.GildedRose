namespace TDDPracticeGildedRose
{
    public class Product
    {
        public Product(TypeProduct especificProduct, string name, int sellIn, int quality)
        {
            EspecificProduct = especificProduct;
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public TypeProduct EspecificProduct { get;}
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set;}

        public void UpdateProduct()
        {
            int decrease = 1;
            if (Quality < 0 || Quality >50)
            {
                throw new Exception("Invalid Sell");
            }else if (SellIn > 0)
            {
                SellIn=SellIn-decrease;
                Quality=Quality-decrease;
            }
            else
                Quality = Quality-2*decrease;
        }
       
    }
}