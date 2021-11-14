using ConsoleRomaine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RomainTest
{
    [TestClass]
    public class NumerationRomaineTest
    {
        [TestMethod]
        public void TestConvertirNegatif()
        {
            Action act = () => NumerationRomaine.Convertir(-5);

            Assert.ThrowsException<NotSupportedException>(act);
        }

        [TestMethod]
        public void TestConvertirZero()
        {
            Action act = () => NumerationRomaine.Convertir(0);

            Assert.ThrowsException<NotSupportedException>(act);
        }

        [TestMethod]
        public void TestConvertir1()
        {
            Assert.AreEqual("I", NumerationRomaine.Convertir(1));
        }

        [TestMethod]
        public void TestConvertir2()
        {
            Assert.AreEqual("II", NumerationRomaine.Convertir(2));
        }

        [TestMethod]
        public void TestConvertir4()
        {
            Assert.AreEqual("IV", NumerationRomaine.Convertir(4));
        }

        [TestMethod]
        public void TestConvertir5()
        {
            Assert.AreEqual("V", NumerationRomaine.Convertir(5));
        }

        [TestMethod]
        public void TestConvertir7()
        {
            Assert.AreEqual("VII", NumerationRomaine.Convertir(7));
        }

        [TestMethod]
        public void TestConvertir9()
        {
            Assert.AreEqual("IX", NumerationRomaine.Convertir(9));
        }

        [TestMethod]
        public void TestConvertir12()
        {
            Assert.AreEqual("XII", NumerationRomaine.Convertir(12));
        }

        [TestMethod]
        public void TestConvertir19()
        {
            Assert.AreEqual("XIX", NumerationRomaine.Convertir(19));
        }

        [TestMethod]
        public void TestConvertir38()
        {
            Assert.AreEqual("XXXVIII", NumerationRomaine.Convertir(38));
        }

        [TestMethod]
        public void TestConvertir42()
        {
            Assert.AreEqual("XLII", NumerationRomaine.Convertir(42));
        }

        [TestMethod]
        public void TestConvertir98()
        {
            Assert.AreEqual("XCVIII", NumerationRomaine.Convertir(98));
        }

        [TestMethod]
        public void TestConvertir177()
        {
            Assert.AreEqual("CLXXVII", NumerationRomaine.Convertir(177));
        }

        [TestMethod]
        public void TestConvertir300()
        {
            Assert.AreEqual("CCC", NumerationRomaine.Convertir(300));
        }

        [TestMethod]
        public void TestConvertir480()
        {
            Assert.AreEqual("CDLXXX", NumerationRomaine.Convertir(480));
        }

        [TestMethod]
        public void TestConvertir1973()
        {
            Assert.AreEqual("MCMLXXIII", NumerationRomaine.Convertir(1973));
        }
    }
}