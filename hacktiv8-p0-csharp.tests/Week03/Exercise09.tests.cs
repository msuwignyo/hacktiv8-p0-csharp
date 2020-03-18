using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise09;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class CariMeanTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 3 };
            yield return new object[] { new int[] { 3, 5, 7, 5, 3 }, 5 };
            yield return new object[] { new int[] { 6, 5, 4, 7, 3 }, 5 };
            yield return new object[] { new int[] { 1, 3, 3 }, 3 };
            yield return new object[] { new int[] { 7, 7, 7, 7, 7 }, 7 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise09
    {
        [Theory]
        [ClassData(typeof(CariMeanTestData))]
        public void CariMeanTest(int[] input, int expected)
        {
            Assert.Equal(expected, CariMean(input));
        }
    }
}