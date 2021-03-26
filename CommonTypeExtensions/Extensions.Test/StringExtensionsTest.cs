using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CommonTypeExtensions.String;

namespace Extensions.Test
{
    [TestClass]
    public class StringExtensionsTest
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


        private static IEnumerable<string[]> GetDataForAfterFirstIndexOf()
        {
            yield return new string[] { "Mustafa", ",", "Mustafa" };
            yield return new string[] { "Mustafa,Bakrolwala", ",", "Bakrolwala" };
            yield return new string[] { "Mustafa,A,Bakrolwala", ",", "A,Bakrolwala" };
        }

        private static IEnumerable<string[]> GetDataForAfterLastIndexOf()
        {
            yield return new string[] { "Mustafa", ",", "Mustafa" };
            yield return new string[] { "Mustafa,Bakrolwala", ",", "Bakrolwala" };
            yield return new string[] { "Mustafa,A,Bakrolwala", ",", "Bakrolwala" };
        }

        private static IEnumerable<string[]> GetDataForBeforeFirstIndexOf()
        {
            yield return new string[] { "Mustafa", ",", "" };
            yield return new string[] { "Mustafa,Bakrolwala", ",", "Mustafa" };
            yield return new string[] { "Mustafa,A,Bakrolwala", ",", "Mustafa" };
        }

        private static IEnumerable<string[]> GetDataForBeforeLastIndexOf()
        {
            yield return new string[] { "Mustafa", ",", "" };
            yield return new string[] { "Mustafa,Bakrolwala", ",", "Mustafa" };
            yield return new string[] { "Mustafa,A,Bakrolwala", ",", "Mustafa,A" };
        }

        private static IEnumerable<object[]> GetDataForContainsFor()
        {
            yield return new object[] { "Mustafa", ",", 0 };
            yield return new object[] { "Mustafa,Bakrolwala", ",", 1 };
            yield return new object[] { "Mustafa,A,Bakrolwala", ",", 2 };
            yield return new object[] { "the tree needed the water from the pump", "the", 3 };
        }
    }
}
