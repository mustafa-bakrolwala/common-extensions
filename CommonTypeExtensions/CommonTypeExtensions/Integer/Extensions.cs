using System;
using System.Collections.Generic;
using System.Text;

namespace CommonTypeExtensions.Integer
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if a number is even
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsEven(this int input)
        {
            return input % 2 == 0 ? true : false;
        }

        /// <summary>
        /// Checks if a number is odd
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsOdd(this int input)
        {
            return input % 2 == 0 ? false : true;
        }

    }
}
