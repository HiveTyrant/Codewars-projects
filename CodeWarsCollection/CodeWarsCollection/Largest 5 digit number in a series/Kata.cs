using System;

namespace CodeWarsCollection.Largest_5_digit_number_in_a_series
{
    public class Kata
    {
        /// <summary>
        /// Returns the largest five digit number found within the number given. The number will be 
        /// passed in as a string of only digits. It should return a five digit integer. The number 
        /// passed may be as large as 1000 digits.
        /// 
        /// Example:
        /// In the following 10 digit number: 1234567890
        /// 67890 is the greatest sequence of 5 digits.
        ///  </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetNumber(string str)
        {
            var res = 0;
            for (var i = 0; i <= str.Length-5; i++)
                res = Math.Max(res, int.Parse(str.Substring(i, 5)));
            return res;
        }
    }
}
