using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise14;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class MengelompokkanAngkaTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {2, 4, 6},
                new[]
                {
                    new[] {2, 4}, new int[] { }, new[] {6}
                }
            };
            yield return new object[]
            {
                new[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                new[]
                {
                    new[] {2, 4, 8}, new[] {1, 5, 7},
                    new[] {3, 6, 9}
                }
            };
            yield return new object[]
            {
                new[] {100, 151, 122, 99, 111},
                new[]
                {
                    new[] {100, 122}, new[] {151},
                    new[] {99, 111}
                }
            };
            yield return new object[]
            {
                new int[] { },
                new[] {new int[] { }, new int[] { }, new int[] { }}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise14
    {
        [Theory]
        [ClassData(typeof(MengelompokkanAngkaTestData))]
        public void MengelompokkanAngkaTest(int[] input, int[][] expected)
        {
            Assert.Equal(expected, MengelompokkanAngka(input));
        }
    }
}