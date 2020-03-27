using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise13;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class TargetTerdekatTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {new[] {' ', ' ', 'o', ' ', ' ', 'x', ' ', 'x'}, 3};
            yield return new object[] {new[] {'o', ' ', ' ', ' ', 'x', 'x', 'x'}, 4};
            yield return new object[] {new[] {'x', ' ', ' ', ' ', 'x', 'x', 'o', ' '}, 1};
            yield return new object[] {new[] {' ', ' ', 'o', ' '}, 0};
            yield return new object[] {new[] {' ', 'o', ' ', 'x', 'x', ' ', ' ', 'x'}, 2};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise13
    {
        [Theory]
        [ClassData(typeof(TargetTerdekatTestData))]
        public void TargetTerdekatTest(char[] input, int expected)
        {
            Assert.Equal(expected, TargetTerdekat(input));
        }
    }
}