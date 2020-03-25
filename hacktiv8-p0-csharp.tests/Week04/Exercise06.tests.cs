using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise06;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class DigitPerkalianMinimumTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 24, 2 };
            yield return new object[] { 90, 3 };
            yield return new object[] { 20, 2 };
            yield return new object[] { 179, 4 };
            yield return new object[] { 1, 2 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise06
    {
        [Theory]
        [ClassData(typeof(DigitPerkalianMinimumTestData))]
        public void DigitPerkalianMinimumTest(int angka, int expected)
        {
            Assert.Equal(expected, DigitPerkalianMinimum(angka));
        }
    }
}
