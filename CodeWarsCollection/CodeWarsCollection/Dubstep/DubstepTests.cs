using NUnit.Framework;

namespace CodeWarsCollection.Dubstep
{
    [TestFixture]
    public class DubstepTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("WUBWUBWUBRWUBWUBWUBWUBWUBWUBLWUB"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("WE ARE THE CHAMPIONS MY FRIEND", Dubstep.SongDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"));
        }
    }
}
