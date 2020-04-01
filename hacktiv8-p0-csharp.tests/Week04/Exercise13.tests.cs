using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise13;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class DeepSumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[][][]
                {
                    new int[][]
                    {
                        new int[] { 4, 5, 6 },
                        new int[] { 9, 1, 2, 10 },
                        new int[] { 9, 4, 3}
                    },
                    new int[][]
                    {
                        new int[] { 4, 14, 31 },
                        new int[] { 9, 10, 18, 12, 20 },
                        new int[] { 1, 4, 90 }
                    },
                    new int[][]
                    {
                        new int[] { 2, 5, 10 },
                        new int[] { 3, 4, 5 },
                        new int[] { 2, 4, 5, 10 }
                    }
                },
                316
            };
            yield return new object[]
            {
                new int[][][]
                {
                    new int[][]
                    {
                        new int[] { 20, 10 },
                        new int[] { 15 },
                        new int[] { 1, 1 }
                    },
                    new int[][]
                    {
                        new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
                        new int[] { 2 },
                        new int[] { 9, 11 }
                    },
                    new int[][]
                    {
                        new int[] { 3, 5, 1 },
                        new int[] { 1, 5, 3 },
                        new int[] { 1 }
                    },
                    new int[][]
                    {
                        new int[] { 2 }
                    }
                },
                156
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise13
    {
        [Theory]
        [ClassData(typeof(DeepSumTestData))]
        public void DeepSumTest(int[][][] arr, int expected)
        {
            Assert.Equal(expected, DeepSum(arr));
        }

        [Fact]
        public void DeepSumTestEmptyArr()
        {
            var exception = Assert.Throws<Exception>(() =>
                DeepSum(new int[][][] { }));

            Assert.Equal("No number", exception.Message);
        }
    }
}