using System.Collections.Generic;
using System.Linq;

namespace CodeWarsCollection.Scramblies
{
    public class Scramblies
    {
        /// <summary>
        /// Return true, if (some of) the letters of str1 can be arranged so that it matches str2
        /// Eample:
        /// str1 is 'rkqodlw' and str2 is 'world' the output should return true.
        /// str1 is 'cedewaraaossoqqyt' and str2 is 'codewars' should return true.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool Scramble(string str1, string str2)
        {
            // Make a collection of how many of the different char exists in the input string
            Dictionary<char, int> charPool = str1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            return str2.All(ch => charPool.ContainsKey(ch) && charPool[ch]-- > 0);
        }

        public static bool ScrambleExtended(string str1, string str2)
        {
            // Make a collection of how many of the different char exists in the input string
            Dictionary<char, int> charPool = str1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            foreach (var ch in str2) if (!charPool.ContainsKey(ch) || charPool[ch]-- <= 0) return false;
            return true;
        }
    }
}
