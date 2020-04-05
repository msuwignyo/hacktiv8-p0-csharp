using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise04;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class TotalDigitRekursifTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 512, 8 };
            yield return new object[] { 1542, 12 };
            yield return new object[] { 5, 5 };
            yield return new object[] { 21, 3 };
            yield return new object[] { 11111, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise04
    {
        [Theory]
        [ClassData(typeof(TotalDigitRekursifTestData))]
        public void TotalDigitRekursifTest(int waktu, int expected)
        {
            Assert.Equal(expected, TotalDigitRekursif(waktu));
        }
    }
}