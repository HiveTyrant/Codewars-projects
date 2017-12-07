using System;
using NUnit.Framework;

namespace CodeWarsCollection.Product_of_consecutive_Fib_numbers
{
    [TestFixture]
    public class ProdFibTests
    {
        [Test]
        [TestCase((ulong)0, new ulong[] {0, 1, 1})]
        [TestCase((ulong)15, new ulong[] {3, 5, 1})]
        [TestCase((ulong)714, new ulong[] { 21, 34, 1 })]
        [TestCase((ulong)4895, new ulong[] { 55, 89, 1 })]
        [TestCase((ulong)800, new ulong[] { 34, 55, 0 })]
        public void Test(ulong prod, ulong[] expected)
        {
            var sut = ProdFib.productFib(prod);
            Assert.AreEqual(expected, sut);
        }

        [Test]
        public void DebugTest()
        {
            var sut = ProdFib.productFib(15);
            Assert.AreEqual(new ulong[] { 3, 5, 1 }, sut);
        }
    }
}