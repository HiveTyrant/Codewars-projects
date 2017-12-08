using System;
using NUnit.Framework;

namespace CodeWarsCollection.Scramblies
{
    [TestFixture]
    public static class ScrambliesTests
    {

        private static void Testing(string str1, string str2, bool expected)
        {
            var res = Scramblies.Scramble(str1, str2);
            Console.WriteLine($"Testing if {str2} can be made by the letters in {str1}. Result: {res}, expected: {expected}");
            Assert.AreEqual(expected, res);
        }

        private static void Testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test1()
        {
            Testing("rkqodlw", "world", true);
            Testing("cedewaraaossoqqyt", "codewars", true);
            Testing("katas", "steak", false);
            Testing("scriptjavx", "javascript", false);
            Testing("scriptingjava", "javascript", true);
            Testing("scriptsjava", "javascripts", true);
            Testing("javscripts", "javascript", false);
            Testing("aabbcamaomsccdd", "commas", true);
            Testing("commas", "commas", true);
            Testing("sammoc", "commas", true);

            // Testing(Scramblies.Scramble("rkqodlw", "world"), true);
            // Testing(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            // Testing(Scramblies.Scramble("katas", "steak"), false);
            // Testing(Scramblies.Scramble("scriptjavx", "javascript"), false);
            // Testing(Scramblies.Scramble("scriptingjava", "javascript"), true);
            // Testing(Scramblies.Scramble("scriptsjava", "javascripts"), true);
            // Testing(Scramblies.Scramble("javscripts", "javascript"), false);
            // Testing(Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            // Testing(Scramblies.Scramble("commas", "commas"), true);
            // Testing(Scramblies.Scramble("sammoc", "commas"), true);
        }
    }
}


