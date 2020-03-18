using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise11;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class TentukanDeretAritmatikanTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6 }, true };
            yield return new object[] { new int[] { 2, 4, 6, 12, 24 }, false };
            yield return new object[] { new int[] { 2, 4, 6, 8 }, true };
            yield return new object[] { new int[] { 2, 5, 18, 54 }, false };
            yield return new object[] { new int[] { 1, 2, 3, 4, 7, 9 }, false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise11
    {
        [Theory]
        [ClassData(typeof(TentukanDeretAritmatikanTestData))]
        public void TentukanDeretAritmatikanTest(int[] input, bool expected)
        {
            Assert.Equal(expected, TentukanDeretAritmatika(input));
        }
    }
}