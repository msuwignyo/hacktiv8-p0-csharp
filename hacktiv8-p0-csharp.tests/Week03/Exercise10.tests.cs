using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise10;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class PerkalianUnikTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {2, 4, 6},
                new[] {24, 12, 8}
            };
            yield return new object[]
            {
                new[] {1, 2, 3, 4, 5},
                new[] {120, 60, 40, 30, 24}
            };
            yield return new object[]
            {
                new[] {1, 4, 3, 2, 5},
                new[] {120, 30, 40, 60, 24}
            };
            yield return new object[]
            {
                new[] {1, 3, 3, 1},
                new[] {9, 3, 3, 9}
            };
            yield return new object[]
            {
                new[] {2, 1, 8, 10, 2},
                new[] {160, 320, 40, 32, 160}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise10
    {
        [Theory]
        [ClassData(typeof(PerkalianUnikTestData))]
        public void PerkalianUnikTest(int[] input, int[] expected)
        {
            Assert.Equal(expected, PerkalianUnik(input));
        }
    }
}