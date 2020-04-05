using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise09;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class CariPelakuTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "mabcvabc", 2 };
            yield return new object[] { "abcdabdc", 1 };
            yield return new object[] { "bcabcac", 1 };
            yield return new object[] { "abcabcabc", 3 };
            yield return new object[] { "babcbacabc", 2 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise09
    {
        [Theory]
        [ClassData(typeof(CariPelakuTestData))]
        public void CariPelakuTest(string str, int expected)
        {
            Assert.Equal(expected, CariPelaku(str));
        }
    }
}