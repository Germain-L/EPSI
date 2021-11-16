using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

// Les étapes recommandées sont :
// Traduire une heure "pile" du matin : ex 7:00 => "sept heures du matin", 1:00 => "une heure du matin"
// Traduire une heure "pile" de l'après-midi : ex 14:00 => "deux heures de l'après-midi"
// Traduire une heure "pile" spéciale : ex 12:00 => "midi", 00:00 => "minuit"
// Gérer les tranches normales de 5 minutes de la première demi-heure  : ex 12:10 => "midi dix", 15:25 => "trois heures vingt-cinq de l'après-midi", 00:15 => "minuit et quart"
// Gérer les tranches spéciales de 5 minutes après la première demi-heure : ex 8:45 => "neuf heures moins le quart", 12:35 => "une heure moins vingt-cinq de l'après-midi"
// Gérer les minutes précises : ex 8:48 => "neuf heures moins dix du matin à deux minutes près", 12:04 => "Midi cinq à une minute prés" 

namespace TestVoiceAssistant
{
    [TestClass]
    public class TestParser
    {
        [TestMethod]
        public void TradHeurePile7H()
        {
            var time = "7:00";
            var result = Parser.Parse(time);

            Assert.AreEqual("il est sept heures du matin", result);
        }

        [TestMethod]
        public void TradHeurePile1H()
        {
            var time = "1:00";
            var result = Parser.Parse(time);

            Assert.AreEqual("il est une heure du matin", result);
        }

        [TestMethod]
        public void TradHeureAprèsMidi14H()
        {
            var time = "14:00";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est deux heures de l'après-midi", result);
        }

        [TestMethod]
        public void TradHeureSpéciale12H()
        {
            var time = "12:00";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est midi", result);
        }

        [TestMethod]
        public void TradHeureSpéciale00H()
        {
            var time = "00:00";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est minuit", result);
        }

        [TestMethod]
        public void TradTrancheDemiHeure12H10()
        {
            var time = "12:10";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est midi dix", result);
        }

        [TestMethod]
        public void TradTrancheDemiHeure15H25()
        {
            var time = "15:25";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est trois heures vingt-cinq de l'après-midi", result);
        }

        [TestMethod]
        public void TradTrancheDemiHeure00H15()
        {
            var time = "00:15";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est minuit et quart", result);
        }
        
        [TestMethod]
        public void TradTrancheDemiHeureSpéciales08H45()
        {
            var time = "8:45";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est neuf heures moins le quart du matin", result);
        }
        
        [TestMethod]
        public void TradTrancheDemiHeureSpéciales12H35()
        {
            var time = "12:35";

            var result = Parser.Parse(time);

            Assert.AreEqual("il est une heure moins vingt-cinq de l'après-midi", result);
        }
    }
}