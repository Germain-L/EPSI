using AtelierStock;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AtelierStockTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Initialisation()
        {
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);
            
            Assert.AreEqual(1m, produitTest.PrixAchat);
            Assert.AreEqual("AT-ST", produitTest.Reference);
            Assert.AreEqual("Parpaingue", produitTest.Libelle);
        }

        [TestMethod]
        public void TestPrixVente()
        {
            // Arrange
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);

            // Act

            // Assert
            Assert.AreEqual(1.3m, produitTest.PrixVente);
        }

        [TestMethod]
        public void TestRupture()
        {
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);
            Assert.AreEqual(true, produitTest.EstEnRupture);
        }

        [TestMethod]
        public void TestRentrer()
        {
            // Arrange
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);
            
            // Act
            produitTest.Rentrer(1);
            
            // Assert
            Assert.AreEqual(1, produitTest.Stocks);
        }

        [TestMethod]
        public void TestSortirNormal()
        {
            // Arrange
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);
            
            // Act
            produitTest.Rentrer(2);

            // Assert
            Assert.AreEqual(1, produitTest.Sortir(1));
        }

        [TestMethod]
        public void TestSortirTrop()
        {
            Produit produitTest = new Produit("AT-ST", "Parpaingue", 1m, 0.30m);


            produitTest.Rentrer(5);
            Assert.AreEqual(5, produitTest.Sortir(6));
        }
    }
}