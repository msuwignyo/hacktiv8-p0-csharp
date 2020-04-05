using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise03;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class MakanTerusRekursifTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 66, 5 };
            yield return new object[] { 100, 7 };
            yield return new object[] { 90, 6 };
            yield return new object[] { 10, 1 };
            yield return new object[] { 0, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise03
    {
        [Theory]
        [ClassData(typeof(MakanTerusRekursifTestData))]
        public void MakanTerusRekursifTest(int waktu, int expected)
        {
            Assert.Equal(expected, MakanTerusRekursif(waktu));
        }
    }
}