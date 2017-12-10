using NUnit.Framework;

namespace CodeWarsCollection.Human_Readable_Time
{
    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest()
        {
            var res = string.Empty;
            Assert.AreEqual(res = TimeFormat.GetReadableTime(0), "00:00:00");
            Assert.AreEqual(res = TimeFormat.GetReadableTime(5), "00:00:05");
            Assert.AreEqual(res = TimeFormat.GetReadableTime(60), "00:01:00");
            Assert.AreEqual(res = TimeFormat.GetReadableTime(86399), "23:59:59");
            Assert.AreEqual(res = TimeFormat.GetReadableTime(359999), "99:59:59");
        }
    }
}
