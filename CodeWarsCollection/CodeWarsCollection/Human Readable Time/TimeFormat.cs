using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsCollection.Human_Readable_Time
{
    public static class TimeFormat
    {
        /// <summary>
        /// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
        ///
        /// HH = hours, padded to 2 digits, range: 00 - 99
        /// MM = minutes, padded to 2 digits, range: 00 - 59
        /// SS = seconds, padded to 2 digits, range: 00 - 59
        /// 
        /// The maximum time never exceeds 359999 (99:59:59)
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static string GetReadableTime(int seconds) => $"{seconds / (60 * 60):D2}:{(seconds % (60 * 60)) / 60:D2}:{seconds % 60:D2}";
    }
}
  