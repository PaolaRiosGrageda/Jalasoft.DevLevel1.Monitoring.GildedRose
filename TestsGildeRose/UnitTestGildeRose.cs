using TDDPracticeGildedRose;

namespace TestsGildeRose
{
    [TestClass]
    public class UnitTestGildeRose
    {
        [TestMethod]
        public void ValidatedNormalProductReturnUpdatedSellInValue()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.Normal,"PineApple",20,30);
            myProduct.UpdateProduct();
            Assert.AreEqual(19,myProduct.SellIn);

        }

        [TestMethod]
        public void ValidatedNormalProductReturnUpdatedQualityInValue()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.Normal, "PineApple", 20, 30);
            myProduct.UpdateProduct();
            Assert.AreEqual(29, myProduct.Quality);

        }
        [TestMethod]
        public void ValidatedNormalProductReturnUpdatedQualitySellPast()
        {
            Product myProduct = new Product(TypeProduct.Normal, "PineApple", 0, 30);
            myProduct.UpdateProduct();
            Assert.AreEqual(28, myProduct.Quality);

        }
        [TestMethod]
        public void ValidatedNormalProductReturnUpdatedQualityNeverNegative()
        {
            Product myProduct = new Product(TypeProduct.Normal, "PineApple", 0, -2);
            string message= string.Empty;
            try
            {
                myProduct.UpdateProduct();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Assert.AreEqual("Invalid Quality", message);
        }
        [TestMethod]
        public void ValidatedAgedBriefReturnUpdatedQuality()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.AgedBrie, "Cheese", 0, 20);
            myProduct.UpdateProduct();
            Assert.AreEqual(21, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedSulfurasReturnUpdatedQuality()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.Sulfuras, "Sulfuras", 0, 80);
            myProduct.UpdateProduct();
            Assert.AreEqual(80, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedSulfurasReturnUpdatedQualityOutRange()
        {
            string message = string.Empty;
            Product myProduct = new Product(TypeProduct.Sulfuras, "Sulfuras", 0, 90);
            try
            {
                myProduct.UpdateProduct();
            }
            catch(Exception ex)
            {
                message= ex.Message;
            }
            Assert.AreEqual("Invalid Quality", message);
        }
        [TestMethod]
        public void ValidatedBackstageUpdatedQualityIncreaseWhenSellToTenSell()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.BackstagePasses, "Backstage",10, 20);
            myProduct.UpdateProduct();
            Assert.AreEqual(22, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedBackstageUpdatedQualityIncreaseWhenSellToTFiveSell()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.BackstagePasses, "Backstage", 5, 20);
            myProduct.UpdateProduct();
            Assert.AreEqual(23, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedBackstageUpdatedQualityIncreaseWhenSellToTCeroSell()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.BackstagePasses, "Backstage", 0, 0);
            myProduct.UpdateProduct();
            Assert.AreEqual(0, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedBackstageUpdatedQualityIncreaseWhenSellToTTwoSell()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.BackstagePasses, "Backstage", 2, 10);
            myProduct.UpdateProduct();
            Assert.AreEqual(13, myProduct.Quality);
        }
        [TestMethod]
        public void ValidatedConjuredWhenDrecreaseQuality()
        {
            // nombre, sellIn, quality
            Product myProduct = new Product(TypeProduct.Conjured, "Conjured", 2, 20);
            myProduct.UpdateProduct();
            Assert.AreEqual(18, myProduct.Quality);

        }
    }
}