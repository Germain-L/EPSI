using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace AtelierShoppingCartTest
{
    [TestClass]
    public class CartTest
    {
        private Cart cartTest = new Cart();

        [TestMethod]
        public void Initialisation()
        {
            // IsEmpty is false when articles count is 0 ???
            // Assert.AreEqual(true, cartTest.IsEmpty);
            // type of Cart is correct
            Assert.AreEqual(typeof(Cart), cartTest.GetType());

            // price should be 0
            Assert.AreEqual(0m, cartTest.TotalPrice);
        }

        #region TestAdd

        [TestMethod]
        public void TestArticlesAdd()
        {
            // act
            cartTest.Add("Parpaing", 6, 1m);

            // Assert
            CollectionAssert.AreEqual(
                new Article[] {new Article("Parpaing", 6, 1m)},
                cartTest.Articles.ToList()
            );
        }

        [TestMethod]
        public void TestArticlesAdd0Price()
        {
            // act
            Action act = () => cartTest.Add("Parpaing", 6, 0m);

            // assert
            Assert.ThrowsException<
                ArgumentOutOfRangeException>(act);
        }

        [TestMethod]
        public void TestArticlesAddNegativePrice()
        {
            // act
            Action act = () => cartTest.Add("Parpaing", 6, -5m);

            // assert
            Assert.ThrowsException<
                ArgumentOutOfRangeException>(act);
        }

        [TestMethod]
        public void TestArticlesAdd0Qty()
        {
            // act
            Action act = () => cartTest.Add("Parpaing", 0, 1m);

            // assert
            Assert.ThrowsException<
                ArgumentOutOfRangeException>(act);
        }

        [TestMethod]
        public void TestArticlesAddNegativeQty()
        {
            // act
            Action act = () => cartTest.Add("Parpaing", -9, 1m);

            // assert
            Assert.ThrowsException<
                ArgumentOutOfRangeException>(act);
        }

        [TestMethod]
        public void TestAddExistingArticle()
        {
            // arrange
            cartTest.Add("Parpaing", 1, 1m);

            // act
            Article actual = cartTest.Add("Parpaing", 1, 1m);

            // assert
            Article expected = new Article("Parpaing", 2, 1m);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddExistingArticleDifferentPrice()
        {
            // Test should add the article without noticing the price difference

            cartTest.Add("Parpaing", 1, 1m);

            // act
            Article actual = cartTest.Add("Parpaing", 1, 3m);

            // assert
            Article expected = new Article("Parpaing", 2, 1m);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestDecrease

        [TestMethod]
        public void TestDecreaseQuantity()
        {
            // arrange
            // adding 2 "parpaing"
            cartTest.Add("parpaing", 2, 1m);

            //act
            cartTest.DecreaseArticleQuantity("parpaing");

            // assert

            CollectionAssert.AreEqual(
                new Article[] {new Article("parpaing", 1, 1m)},
                cartTest.Articles.ToList() // using System.Linq;
            );
        }

        [TestMethod]
        public void TestRemoveWithDecrease()
        {
            cartTest.Add("parpaing", 1, 1m);

            // assert
            // Articles should be empty
            cartTest.DecreaseArticleQuantity("parpaing");
            CollectionAssert.AreEqual(
                new Article[] { },
                cartTest.Articles.ToList() // using System.Linq;
            );
        }

        [TestMethod]
        public void TestRemoveInexistant()
        {
            Action act = () => cartTest.DecreaseArticleQuantity("parpaing");

            Assert.ThrowsException<System.ArgumentException>(act);
        }

        #endregion

        #region TestIsEmpty

        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.AreEqual(true, cartTest.IsEmpty);
        }

        [TestMethod]
        public void TestIsNotEmpty()
        {
            cartTest.Add("Parpaingue", 6, 6m);
            Assert.AreEqual(false, cartTest.IsEmpty);
        }

        #endregion

        #region TotalPrice

        [TestMethod]
        public void TestTotalNotZero()
        {
            cartTest.Add("Parpaingue", 6, 6m);
            cartTest.Add("Brique", 3, 2m);
            cartTest.Add("Fer", 12, 3.5m);

            decimal total = (6 * 6m) + (3 * 2m) + (12 * 3.5m);
            Assert.AreEqual(total, cartTest.TotalPrice);
        }

        [TestMethod]
        public void TestTotalZero()
        {
            Assert.AreEqual(0, cartTest.TotalPrice);
        }

        #endregion
    }
}