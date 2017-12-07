using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CodeWarsCollection.MorseCodeDecoder
{
    public class MorseCodeDecoder
    {
        /// <summary> Simple Morse code decoder </summary>
        /// <param name="morseCode">Morse code, eg: ".... . -.--   .--- ..- -.. ."</param>
        /// <returns>morseCode decoded into a string, eg: "HEY JUDE"</returns>
        /// <remarks>
        /// Specification states: 
        ///  - All the test strings would contain valid Morse code, so you may skip checking for errors and exceptions
        ///  - Extra spaces before or after the code have no meaning and should be ignored
        ///  - The Morse code table is preloaded for you as a dictionary, that is accessed like: MorseCode.Get('.--') 
        /// </remarks>
        public static string Decode(string morseCode)
        {
            return string.Join("", morseCode.Trim(' ').Replace("   ", " # " ).Split(' ').Select(c => c=="#" ? " " : MorseCode.Get(c)));
        }

    }

    public class MorseCode
    {
        public static string Get(string code)
        {
            return "x";
        }
    }
}
