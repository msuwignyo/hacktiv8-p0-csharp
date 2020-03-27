using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise04;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class CariModusTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {10, 4, 5, 2, 4},
                4
            };
            yield return new object[]
            {
                new[] {5, 10, 10, 6, 5},
                5
            };
            yield return new object[]
            {
                new[] {10, 3, 1, 2, 5},
                -1
            };
            yield return new object[]
            {
                new[] {1, 2, 3, 3, 4, 5},
                3
            };
            yield return new object[]
            {
                new[] {7, 7, 7, 7, 7},
                -1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise04
    {
        [Theory]
        [ClassData(typeof(CariModusTestData))]
        public void CariModusTest(int[] arr, double expected)
        {
            Assert.Equal(expected, CariModus(arr));
        }
    }
}