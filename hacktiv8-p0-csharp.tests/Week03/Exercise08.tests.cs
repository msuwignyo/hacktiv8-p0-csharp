using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise08;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class PasanganTerbesarTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 641573, 73 };
            yield return new object[] { 12783456, 83 };
            yield return new object[] { 910233, 91 };
            yield return new object[] { 71856421, 85 };
            yield return new object[] { 79918293, 99 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise08
    {
        [Theory]
        [ClassData(typeof(PasanganTerbesarTestData))]
        public void PasanganTerbesarTest(int input, int expected)
        {
            Assert.Equal(expected, PasanganTerbesar(input));
        }
    }
}