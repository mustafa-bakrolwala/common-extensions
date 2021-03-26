using System;
using System.Collections.Generic;
using System.Text;

namespace CommonTypeExtensions.String
{
    public static class Extensions
    {
        /// <summary>
        /// Return a string after the first occurence of a particular string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string AfterFirstIndexOf(this string input, string value)
        {
            return input.Substring(input.IndexOf(value) + 1);
        }

        /// <summary>
        /// Return a string after the last occurence of a particular string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string AfterLastIndexOf(this string input, string value)
        {
            return input.Substring(input.LastIndexOf(value) + 1);
        }

        /// <summary>
        /// Returns a string before the first occurence of a particular string. Returns empty string if the string to search does not exist
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string BeforeFirstIndexOf(this string input, string value)
        {
            if (input.IndexOf(value) == -1)
            {
                return string.Empty;
            }
            return input.Substring(0, input.IndexOf(value));
        }

        /// <summary>
        /// Returns a string before the first occurence of a particular string. Returns empty string if the string to search does not exist
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string BeforeLastIndexOf(this string input, string value)
        {
            if (input.IndexOf(value) == -1)
            {
                return string.Empty;
            }
            return input.Substring(0, input.LastIndexOf(value));
        }

        /// <summary>
        /// Returns number of times a specific string occurs in an input string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ContainsFor(this string input, string value)
        {
            return input.Split(value).Length - 1;
        }
    }
}
