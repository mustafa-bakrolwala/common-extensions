using CommonTypeExtensions.Integer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Test
{
    [TestClass]
    public partial class IntegerExtensionsTest
    {
        [DynamicData(nameof(GetDataForEven), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestEven(int input,bool actualResult)
        {
            bool result = input.IsEven();
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForOdd), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestOdd(int input, bool actualResult)
        {
            bool result = input.IsOdd();
            Assert.AreEqual(result, actualResult);
        }
    }
}
