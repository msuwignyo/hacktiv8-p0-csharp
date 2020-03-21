using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise12;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class TentukanDeretGeometriTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new double[] { 1, 3, 9, 27, 81 }, true };
            yield return new object[] { new double[] { 2, 4, 8, 16, 32 }, true };
            yield return new object[] { new double[] { 2, 4, 6, 8 }, false };
            yield return new object[] { new double[] { 2, 6, 18, 54 }, true };
            yield return new object[] { new double[] { 1, 2, 3, 4, 7, 9 }, false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise12
    {
        [Theory]
        [ClassData(typeof(TentukanDeretGeometriTestData))]
        public void TentukanDeretGeometriTest(double[] input, bool expected)
        {
            Assert.Equal(expected, TentukanDeretGeometri(input));
        }
    }
}