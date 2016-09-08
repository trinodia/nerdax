using System;
using System.ComponentModel;

namespace Nardax
{
    public static class StringExtensions
    {

        /// <summary>
        /// Klipp av en sträng från vänster
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }

       
    }
}
