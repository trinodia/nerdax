using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Klipp av en sträng från höger
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }


        public static string RemoveWhiteChars(this string value)
        {
            return Regex.Replace(value, "\\s", "");
        }
    }
}
