using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise08;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class HapusSimbolTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "test%$4aa", "test4aa" };
            yield return new object[] { "devel0p3r s3j@@ati", "devel0p3rs3jati" };
            yield return new object[] { "ma@#k!an~", "makan" };
            yield return new object[] { "coding", "coding" };
            yield return new object[] { "1+3-5*2=100", "1352100" };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise08
    {
        [Theory]
        [ClassData(typeof(HapusSimbolTestData))]
        public void HapusSimbolTest(string str, string expected)
        {
            Assert.Equal(expected, HapusSimbol(str));
        }
    }
}