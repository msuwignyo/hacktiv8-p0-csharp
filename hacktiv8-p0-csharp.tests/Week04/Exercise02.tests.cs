using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise02;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class FPBTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {12, 16, 4};
            yield return new object[] {50, 40, 10};
            yield return new object[] {22, 99, 11};
            yield return new object[] {24, 36, 12};
            yield return new object[] {17, 23, 1};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise02
    {
        [Theory]
        [ClassData(typeof(FPBTestData))]
        public void FPBTest(int angka1, int angka2, int expected)
        {
            Assert.Equal(expected, FPB(angka1, angka2));
        }
    }
}