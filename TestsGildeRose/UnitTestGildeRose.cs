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
        public void ValidatedNormalProductReturnUpdatedSellNeverNegative()
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
            Assert.AreEqual("Invalid Sell", message);
        }
        //[TestMethod]
        //public void ValidatedAgedBriefReturnUpdatedQuality()
        //{
        //    Product myProduct = new Product(TypeProduct.AgedBrie, "Cheese", 0,20 );
        //    myProduct.UpdateProduct();
        //    Assert.AreEqual(28, myProduct.Quality);
        //}
    }
}