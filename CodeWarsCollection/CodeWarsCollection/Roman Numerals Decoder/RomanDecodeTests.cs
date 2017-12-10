using NUnit.Framework;

namespace CodeWarsCollection.Roman_Numerals_Decoder
{
    [TestFixture]
    public class RomanDecodeTests
    {
        [TestCase(1, "I")]
        [TestCase(21, "XXI")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        public void Test(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }
    }
}
