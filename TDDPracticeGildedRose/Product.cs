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

        public TypeProduct EspecificProduct { get; }
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set;}

        public void UpdateProduct()
        {
            int decrease = 1;
            if (Quality < 0 || (Quality > 50 && EspecificProduct != TypeProduct.Sulfuras))
            {
                throw new Exception("Invalid Quality");
            }

            switch (EspecificProduct)
            {
                case TypeProduct.Normal:
                    if (SellIn > 0)
                    {
                        SellIn -= decrease;
                        Quality -= decrease;
                    }
                    else
                        Quality = Quality - 2 * decrease;
                    SellIn -= decrease;
                    break;
                case TypeProduct.AgedBrie:
                    SellIn -= decrease;
                    Quality++;
                    break;
                case TypeProduct.Sulfuras:
                    SellIn -= decrease;
                    if(Quality != 80)
                        throw new Exception("Invalid Quality");
                    break;
                case TypeProduct.BackstagePasses:
                    SellIn -= decrease;
                    
                    if(SellIn > 5 && SellIn < 10)
                    {
                        Quality += 2;
                    }
                    else if(SellIn > 0 && SellIn <= 5)
                    {
                        Quality += 3;
                    } 
                    else if(SellIn <= 0)
                    {
                        Quality = 0;
                    }
                    break;
                case TypeProduct.Conjured:
                    SellIn-= decrease;
                    Quality -= 2 * decrease;
                    break;
                default:
                    break;
            }

            if(EspecificProduct != TypeProduct.Sulfuras && Quality > 50)
            {
                Quality = 50;
            }

            if(Quality < 0)
            {
                Quality = 0;
            }
        }
       
    }
}