using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace TestVoiceAssistant
{
    [TestClass]
    public class TestParser
    {
        // [TestMethod]
        // public void TestParseReturnString()
        // {
        //     Assert.AreEqual(typeof(string), Parser.Parse("07:15").GetType());
        // }

        [TestMethod]
        public void TestParserFormat()
        {
            string time = "22:56";
            Assert.AreEqual(time, Parser.Parse(time));
        }
        
        [TestMethod]
        public void TestParserWithWrongFormat()
        {
            string time = "24:89";

            Action act = () => Parser.Parse(time);

            Assert.ThrowsException<FormatException>(act);
        }

        [TestMethod]
        public void TestConvertOne()
        {
            string time = "01:00";
            
            Assert.AreEqual("il est une heure du matin", Parser.Parse(time));
        }

        [TestMethod]
        public void TestConvertMinute()
        {
            
        }
    }
}