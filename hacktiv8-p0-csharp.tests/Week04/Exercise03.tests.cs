using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise03;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class CariMedianTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {1, 2, 3, 4, 5},
                3
            };
            yield return new object[]
            {
                new[] {1, 3, 4, 10, 12, 13},
                7
            };
            yield return new object[]
            {
                new[] {3, 4, 7, 6, 10},
                6
            };
            yield return new object[]
            {
                new[] {1, 3, 3},
                3
            };
            yield return new object[]
            {
                new[] {7, 7, 8, 8},
                7.5
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise03
    {
        [Theory]
        [ClassData(typeof(CariMedianTestData))]
        public void CariMedianTest(int[] arr, double expected)
        {
            Assert.Equal(expected, CariMedian(arr));
        }
    }
}