using System.Linq;

namespace CodeWarsCollection.Which_Are_In
{
    class WhichAreIn
    {
        /// <summary>
        /// Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
        /// 
        /// #Example 1: a1 = ["arp", "live", "strong"]
        /// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
        /// returns["arp", "live", "strong"]
        /// 
        /// # Example 2: a1 = ["tarp", "mice", "bull"]
        /// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
        /// returns[]
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static string[] inArray(string[] a1, string[] a2) => a1.Where(s1 => a2.Any(s2 => s2.Contains(s1))).OrderBy(s => s).ToArray();
    }
}
