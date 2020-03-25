using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise01;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class AngkaPrimaTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, true };
            yield return new object[] { 7, true };
            yield return new object[] { 6, false };
            yield return new object[] { 23, true };
            yield return new object[] { 33, false };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Exercise01
    {
        [Theory]
        [ClassData(typeof(AngkaPrimaTestData))]
        public void AngkaPrimaTest(int angka, bool expected)
        {
            Assert.Equal(expected, AngkaPrima(angka));
        }
    }
}
