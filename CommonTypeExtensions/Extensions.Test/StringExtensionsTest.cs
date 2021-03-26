using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CommonTypeExtensions.String;
using System.Text;

namespace Extensions.Test
{
    [TestClass]
    public partial class StringExtensionsTest
    {
        [DynamicData(nameof(GetDataForAfterFirstIndexOf), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestAfterFirstIndexOf(string input, string value, string actualResult)
        {
            string result = input.AfterFirstIndexOf(value);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForAfterLastIndexOf), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestAfterLastIndexOf(string input, string value, string actualResult)
        {
            string result = input.AfterLastIndexOf(value);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForBeforeFirstIndexOf), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestBeforeFirstIndexOf(string input, string value, string actualResult)
        {
            string result = input.BeforeFirstIndexOf(value);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForBeforeLastIndexOf), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestBeforeLastIndexOf(string input, string value, string actualResult)
        {
            string result = input.BeforeLastIndexOf(value);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForContainsFor), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestContainsFor(string input, string value, int actualResult)
        {
            int result = input.ContainsFor(value);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForIsEmpty), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestIsEmpty(string input, bool actualResult)
        {
            bool result = input.IsEmpty();
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForIsNull), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestIsNull(string input, bool actualResult)
        {
            bool result = input.IsNull();
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForBetweenString), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestBetweenString(string input, string start, string end, string actualResult)
        {
            string result = input.Between(start, end);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForBetweenInt), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestBetweenInt(string input, int start, int end, string actualResult)
        {
            string result = input.Between(start, end);
            Assert.AreEqual(result, actualResult);
        }

        [DynamicData(nameof(GetDataForSB), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestSB(string input, StringBuilder actualResult)
        {
            StringBuilder result = input.ToStringBuilder();
            Assert.AreEqual(result.ToString(), actualResult.ToString());
        }

    }
}
