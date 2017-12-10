using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsCollection.Roman_Numerals_Decoder
{
    public class RomanDecode
    {
        private static readonly Dictionary<char, int> RomanNumberLookup = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        /// <summary>
        /// Takes a Roman numeral as its argument and returns its value as a numeric decimal integer. 
        /// 
        /// Modern Roman numerals are written by expressing each decimal digit of the number to be encoded 
        /// separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered 
        /// "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). 
        /// The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
        /// </summary>
        /// <param name="roman"></param>
        /// <returns></returns>
        public static int Solution(string roman) => 
            roman.ToCharArray()
                 .Reverse()
                 .Select(c => RomanNumberLookup[c])
                 // Run a Aggregate function to accumulate the ruman numerals now converted to a IEnumerable<int>
                 .Aggregate(
                     // Use an initializes anonymous type as seeded accumulator value
                     new { MaxValue = 0, RunningTotal = 0 },
                     // Accumulator function invoked on each number in the list.
                     (currentAccumulatorState, curNumber) => new
                     {
                         MaxValue = Math.Max(currentAccumulatorState.MaxValue, curNumber),
                         RunningTotal = curNumber >= currentAccumulatorState.MaxValue
                             ? currentAccumulatorState.RunningTotal + curNumber
                             : currentAccumulatorState.RunningTotal - curNumber
                     },
                     // Function, that transforms final accumulator value into result value
                     finalAccumulatorState => finalAccumulatorState.RunningTotal);
    }
}
