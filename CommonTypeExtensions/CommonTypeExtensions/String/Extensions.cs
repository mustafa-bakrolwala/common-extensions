using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeExtensions.String
{
    public static class Extensions
    {
        /// <summary>
        /// Return a string after the first occurence of a particular string. Returns original string if string to search not found.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string AfterFirstIndexOf(this string input, string value)
        {
            return input.Substring(input.IndexOf(value) + 1);
        }

        /// <summary>
        /// Return a string after the last occurence of a particular string. Returns original string if string to search not found.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string AfterLastIndexOf(this string input, string value)
        {
            return input.Substring(input.LastIndexOf(value) + 1);
        }

        /// <summary>
        /// Returns a string before the first occurence of a particular string. Returns empty string if the string to search not found
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
        /// Returns a string before the first occurence of a particular string. Returns empty string if the string to search not found.
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

        /// <summary>
        /// Checks if a string is Empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string input)
        {
            return input == string.Empty ? true : false;
        }

        /// <summary>
        /// Checks if a string is Empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNull(this string input)
        {
            return input == null ? true : false;
        }

        /// <summary>
        /// Returns a string between the characters specified
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string Between(this string input, string start, string end)
        {
            return input.AfterFirstIndexOf(start).BeforeFirstIndexOf(end);
        }

        /// <summary>
        /// Returns a string between the indexes specified
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value">The string to seek</param>
        /// <returns></returns>
        public static string Between(this string input, int start, int end)
        {
            if (end >= input.Length)
            {
                throw new ArgumentException("Ending index greater than the length of input string");
            }
            if (start < 0)
            {
                throw new ArgumentException("Starting index cannot be less than 0");
            }

            return input.Substring(start, end - start);
        }

        /// <summary>
        /// Returns a StringBuilder instance for the specified string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static StringBuilder ToStringBuilder(this string input)
        {
            return new StringBuilder(input);
        }
    }
}
