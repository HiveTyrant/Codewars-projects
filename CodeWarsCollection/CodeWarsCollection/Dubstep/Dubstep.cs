using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsCollection.Dubstep
{
    public class Dubstep
    {
        /// <summary>
        /// Returns input string, where any "WUB"-substings has been replaced with spaces, except at start and end, where they are removed
        /// </summary>
        /// <param name="input">Non-empty string, containing a number of singl or multi letter words, separated by 'WUB'-substrings</param>
        /// <returns>All "WUB"-substrings replaced by space chars - and trimmed for leading/trailing space chars</returns>
        public static string SongDecoderRegEx(string input) => new Regex(" {2,}", RegexOptions.Compiled).Replace(input.Replace("WUB", " ").Replace("  ", " ").Trim(' '), " ");
        public static string SongDecoder(string input) => input.Replace("WUB", " ").Replace(" ", "¤!!££!!¤").Replace("£!!¤¤!!£", "").Replace("¤!!££!!¤", " ").Trim(' ');
    }
}
