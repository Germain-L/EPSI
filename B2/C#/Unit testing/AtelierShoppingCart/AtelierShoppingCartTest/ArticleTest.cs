using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace AtelierShoppingCartTest
{
    [TestClass]
    public class ArticleTest
    {
        private Article articleTest = new Article("AT-ST", 6, 3m);
        
        [TestMethod]
        public void Initialisation()
        {
            Article articleTest = new Article("AT-ST", 6, 0.30m);

            Assert.AreEqual("AT-ST", articleTest.ProductName);
            Assert.AreEqual(6, articleTest.Quantity);
            Assert.AreEqual(0.30m, articleTest.Price);
        }
        
        [TestMethod]
        public void InitialisationPriceError()
        {   
            // act
            Action act = () => new Article("AT-ST", 6, -0.30m);
            
            // assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(act);
        }
    }
}