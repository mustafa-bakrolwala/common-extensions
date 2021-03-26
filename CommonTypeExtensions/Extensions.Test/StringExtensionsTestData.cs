using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Test
{
    public partial class StringExtensionsTest
    {
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

        private static IEnumerable<object[]> GetDataForIsEmpty()
        {
            yield return new object[] { "Mustafa", false };
            yield return new object[] { "", true };
        }

        private static IEnumerable<object[]> GetDataForIsNull()
        {
            yield return new object[] { "", false };
            yield return new object[] { null, true };
            yield return new object[] { "Mustafa", false };
        }

        private static IEnumerable<object[]> GetDataForBetweenString()
        {
            yield return new object[] { "Mustafa", "'", "'", "" };
            yield return new object[] { "'Mustafa,Bakrolwala'", "'", "'", "Mustafa,Bakrolwala" };
            yield return new object[] { "Mus'tafa,A,Bakro-lwala", "'", "-", "tafa,A,Bakro" };
        }

        private static IEnumerable<object[]> GetDataForBetweenInt()
        {
            yield return new object[] { "Mustafa", 0, 2, "Mu" };
            yield return new object[] { "'Mustafa,Bakrolwala'", 0, 0, "" };
        }

        private static IEnumerable<object[]> GetDataForSB()
        {
            yield return new object[] { "Mustafa", new StringBuilder("Mustafa") };
            yield return new object[] { null, new StringBuilder("") };
        }
    }
}
