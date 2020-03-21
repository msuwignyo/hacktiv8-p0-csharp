using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week02.Exercise10;

namespace hacktiv8_p0_csharp.tests.Week02
{
    public class BandingkanAngkaTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 5, 8, 1 };
            yield return new object[] { 5, 3, 0 };
            yield return new object[] { 4, 4, -1 };
            yield return new object[] { 3, 3, -1 };
            yield return new object[] { 17, 2, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise10
    {
        [Theory]
        [ClassData(typeof(BandingkanAngkaTestData))]
        public void BandingkanAngkaTest(int angka1, int angka2, int expected)
        {
            Assert.Equal(expected, BandingkanAngka(angka1, angka2));
        }
    }
}
