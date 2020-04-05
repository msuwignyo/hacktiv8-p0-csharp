using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise05;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class KaliTerusRekursifTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 66, 8 };
            yield return new object[] { 3, 3 };
            yield return new object[] { 24, 8 };
            yield return new object[] { 654, 0 };
            yield return new object[] { 1231, 6 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise05
    {
        [Theory]
        [ClassData(typeof(KaliTerusRekursifTestData))]
        public void KaliTerusRekursifTest(int waktu, int expected)
        {
            Assert.Equal(expected, KaliTerusRekursif(waktu));
        }
    }
}