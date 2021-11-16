using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectScheduler;
using System;
using System.Data;

namespace ProjectSchedulerTest
{
    [TestClass]
    public class TaskTest
    {
        private readonly DateTime
            Xmas11h00 = new DateTime(2021, 12, 25, 11, 0, 0),
            Xmas12h30 = new DateTime(2021, 12, 25, 12, 30, 0),
            Xmas14h00 = new DateTime(2021, 12, 25, 14, 0, 0),
            Jan1st12h30 = new DateTime(2022, 1, 1, 12, 30, 0);

        #region Initialization

        [TestMethod]
        public void InitAllParameters()
        {
            var stubClock = new Mock<IClock>();

            stubClock.Setup(clock => clock.Now).Returns(Xmas12h30);
            IClock.SetTestClock(stubClock.Object);

            var test = new Task("foo", Xmas11h00, Xmas14h00);

            Assert.IsTrue(test.HasEnd);
            Assert.IsTrue(test.HasDuration);
            Assert.AreEqual("foo", test.Title);
            Assert.AreEqual(Xmas11h00, test.Start);
            Assert.AreEqual(Xmas14h00, test.End);
            Assert.AreEqual(TimeSpan.FromHours(3), test.Duration);
            // TODO: Check Guid ?
            Assert.IsTrue(test.IsStarted);
        }

        [TestMethod]
        public void InitAllParametersYearChange()
        {
            var test = new Task("foo", Xmas12h30, Jan1st12h30);

            Assert.AreEqual(TimeSpan.FromDays(7), test.Duration);
        }

        [TestMethod]
        public void InitWithDefaultStartDate()
        {
            var stubClock = new Mock<IClock>();

            stubClock.Setup(clock => clock.Now).Returns(Xmas12h30);
            IClock.SetTestClock(stubClock.Object);

            var test = new Task("foo");

            Assert.AreEqual(Xmas12h30, test.Start);
        }

        [TestMethod]
        public void InitNoEndDateWithPastStartDate()
        {
            var stubClock = new Mock<IClock>();

            var past = new DateTime(2012, 1, 1, 12, 30, 0);

            stubClock.Setup(clock => clock.Now).Returns(past);
            IClock.SetTestClock(stubClock.Object);

            var test = new Task("foo");

            Assert.AreEqual(past, test.Start);
        }

        [TestMethod]
        public void InitNoEndDateWithStartDateAtNow()
        {
            var stubClock = new Mock<IClock>();

            var now = stubClock.Object.Now;


            stubClock.Setup(clock => clock.Now).Returns(now);
            IClock.SetTestClock(stubClock.Object);

            var test = new Task("foo");

            Assert.AreEqual(now, test.Start);
        }

        [TestMethod]
        public void InitNoEndDateWithFutureStartDate()
        {
            var stubClock = new Mock<IClock>();

            var future = new DateTime(2022, 1, 1, 12, 30, 0);

            stubClock.Setup(clock => clock.Now).Returns(future);
            IClock.SetTestClock(stubClock.Object);

            var test = new Task("foo");

            Assert.AreEqual(future, test.Start);
        }

        [TestMethod]
        public void InitWithNullTitle()
        {
            Action act = () => new Task(null, Xmas12h30, Xmas14h00);

            Assert.ThrowsException<NullReferenceException>(act);
        }

        [TestMethod]
        public void InitWithBadEndDate()
        {
            Action act = () => new Task("foo", Xmas12h30, Xmas11h00);

            Assert.ThrowsException<ArgumentOutOfRangeException>(act);
        }

        #endregion

        #region Change Title

        [TestMethod]
        public void ChangeTitle()
        {
            var test = new Task("foo", Xmas12h30, Xmas14h00);

            test.Title = "bar";

            Assert.AreEqual("bar", test.Title);
        }

        [TestMethod]
        public void ChangeNullTitle()
        {
            var test = new Task("foo", Xmas12h30, Xmas14h00);

            Action act = () => test.Title = null;

            Assert.ThrowsException<NullReferenceException>(act);
        }

        #endregion

        #region Change Start

        [TestMethod]
        public void ChangeStartForEndedTask()
        {
            var test = new Task("foo", Xmas12h30, Xmas14h00);

            test.Start = Xmas11h00;

            Assert.IsTrue(test.HasEnd);
            Assert.IsTrue(test.HasDuration);
            Assert.AreEqual(Xmas11h00, test.Start);
            Assert.AreEqual(Xmas12h30, test.End);
            Assert.AreEqual(TimeSpan.FromMinutes(90), test.Duration);
        }

        [TestMethod]
        public void ChangeStartForNotEndedTaskFromPastToPast()
        {
            // TODO: future/past ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void ChangeStartForNotEndedTaskFromFutureToPast()
        {
            // TODO: future/past ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void ChangeStartForNotEndedTaskFromPastToFuture()
        {
            // TODO: future/past ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void ChangeStartForNotEndedTaskFromFutureToFuture()
        {
            // TODO: future/past ?
            Assert.Fail("Not implemented");
        }

        #endregion

        #region Change End

        [TestMethod]
        public void ChangeEnd()
        {
            var test = new Task("foo", Xmas11h00, Xmas14h00);

            test.End = Xmas12h30;

            Assert.IsTrue(test.HasEnd);
            Assert.IsTrue(test.HasDuration);
            Assert.AreEqual(Xmas11h00, test.Start);
            Assert.AreEqual(Xmas12h30, test.End);
            Assert.AreEqual(TimeSpan.FromMinutes(90), test.Duration);
        }

        [TestMethod]
        public void ChangeEndBeforeStart()
        {
            var test = new Task("foo", Xmas12h30, Xmas14h00);

            Action act = () => test.End = Xmas11h00;

            Assert.ThrowsException<ArgumentOutOfRangeException>(act);
        }

        #endregion

        #region FromDb

        [TestMethod]
        public void FromDbNullEndDate()
        {
            var stubDataReader = new Mock<IDataReader>();

            stubDataReader.Setup(reader => reader.GetGuid(0))
                .Returns(Guid.Parse("88F76BA1-C8A3-4261-BA44-76611DD4EBC1"));
            stubDataReader.Setup(reader => reader.GetString(1))
                .Returns("foo");
            stubDataReader.Setup(reader => reader.GetDateTime(2))
                .Returns(Xmas11h00);
            stubDataReader.Setup(reader => reader.IsDBNull(3))
                .Returns(true);

            var test = Task.FromDb(stubDataReader.Object);

            Assert.IsFalse(test.HasEnd);
            Assert.IsFalse(test.HasDuration);
            Assert.AreEqual(Guid.Parse("88F76BA1-C8A3-4261-BA44-76611DD4EBC1"), test.Id);
            Assert.AreEqual("foo", test.Title);
            Assert.AreEqual(Xmas11h00, test.Start);
        }

        [TestMethod]
        public void FromDbValidEndDate()
        {
            var stubDataReader = new Mock<IDataReader>();

            stubDataReader.Setup(reader => reader.GetGuid(0))
                .Returns(Guid.Parse("88F76BA1-C8A3-4261-BA44-76611DD4EBC1"));
            stubDataReader.Setup(reader => reader.GetString(1))
                .Returns("foo");
            stubDataReader.Setup(reader => reader.GetDateTime(2))
                .Returns(Xmas11h00);
            stubDataReader.Setup(reader => reader.IsDBNull(3))
                .Returns(true);

            Task test = Task.FromDb(stubDataReader.Object);
            test.End = Jan1st12h30;

            Assert.IsTrue(test.HasEnd);
            Assert.IsTrue(test.HasDuration);
            Assert.AreEqual(Guid.Parse("88F76BA1-C8A3-4261-BA44-76611DD4EBC1"), test.Id);
            Assert.AreEqual("foo", test.Title);
            Assert.AreEqual(Xmas11h00, test.Start);
            Assert.AreEqual(Jan1st12h30, test.End);
        }

        [TestMethod]
        public void FromDbEndDateBeforeStartDate()
        {
            var stubDataReader = new Mock<IDataReader>();

            stubDataReader.Setup(reader => reader.GetGuid(0))
                .Returns(Guid.Parse("88F76BA1-C8A3-4261-BA44-76611DD4EBC1"));
            stubDataReader.Setup(reader => reader.GetString(1))
                .Returns("foo");
            stubDataReader.Setup(reader => reader.GetDateTime(2))
                .Returns(Jan1st12h30);
            stubDataReader.Setup(reader => reader.IsDBNull(3))
                .Returns(true);

            Task test = Task.FromDb(stubDataReader.Object);

            Action act = () => test.End = Xmas11h00;

            Assert.ThrowsException<ArgumentOutOfRangeException>(act);
        }

        #endregion

        #region FromXml

        [TestMethod]
        public void FromXmlWithEndDate()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlNoEndDate()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlNoTitle()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlNoStartDate()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlNoGuid()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlInvalidGuid()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlInvalidStartDate()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromXmlInvalidEndDate()
        {
            // TODO: XmlReader ?
            Assert.Fail("Not implemented");
        }

        #endregion

        #region ToXml

        [TestMethod]
        public void ToXmlWithDate()
        {
            var mockWriter = new Mock<IXmlWriter>();

            var test = new Task("foo", Xmas11h00, Xmas14h00);

            test.ToXml(mockWriter.Object);

            mockWriter.Verify(writer => writer.WriteStartElement("task"), Times.Once);
            // TODO : mockWriter.Verify(writer => writer.WriteAttributeString("id", "???"), Times.Once);
            mockWriter.Verify(writer => writer.WriteAttributeString("title", "foo"), Times.Once);
            mockWriter.Verify(writer => writer.WriteAttributeString("start", "12/25/2021 11:00:00"), Times.Once);
            mockWriter.Verify(writer => writer.WriteAttributeString("end", "12/25/2021 14:00:00"), Times.Once);
            mockWriter.Verify(writer => writer.WriteEndElement(), Times.Once);
        }

        [TestMethod]
        public void ToXmlWithNoDate()
        {
            // TODO: XmlWriter ?
            Assert.Fail("Not implemented");
        }

        #endregion

        #region FromCsv

        [TestMethod]
        public void FromCsvWithEndDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvNoEndDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvNoStartDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvInvalidGuid()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvInvalidStartDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvInvalidEndDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void FromCsvInvalidCalendarDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        #endregion

        #region ToCsv

        [TestMethod]
        public void ToCsvWithDate()
        {
            // TODO: TextWriter ?
            Assert.Fail("Not implemented");
        }

        [TestMethod]
        public void ToCsvWithNoDate()
        {
            // TODO: TextReader ?
            Assert.Fail("Not implemented");
        }

        #endregion
    }
}