using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Test
{
    public partial class IntegerExtensionsTest
    {
        private static IEnumerable<object[]> GetDataForEven()
        {
            yield return new object[] { 1, false };
            yield return new object[] { 2, true };
        }

        private static IEnumerable<object[]> GetDataForOdd()
        {
            yield return new object[] { 1, true };
            yield return new object[] { 2, false };
        }
    }
}
