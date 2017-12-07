using System;
using NUnit.Framework;
using NUnit.Framework;

namespace CodeWarsCollection.MorseCodeDecoder
{
    [TestFixture]
    public class MorseCodeDecoderTests
    {
        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                var input = ".... . -.--   .--- ..- -.. .";
                var expected = "HEY JUDE";

                var actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderUnknownCodeTest()
        {
            Assert.That(() => MorseCodeDecoder.Decode("XXX"), Throws.TypeOf<ArgumentException>());
        }
    }
}