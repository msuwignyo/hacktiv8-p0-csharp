using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise08;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class TukarBesarKecilTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"Hello World", "hELLO wORLD"};
            yield return new object[] {"I aM aLAY", "i Am Alay"};
            yield return new object[] {"My Name is Bond!!", "mY nAME IS bOND!!"};
            yield return new object[] {"IT sHOULD bE me", "it Should Be ME"};
            yield return new object[] {"001-A-3-5TrdYW", "001-a-3-5tRDyw"};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise08
    {
        [Theory]
        [ClassData(typeof(TukarBesarKecilTestData))]
        public void TukarBesarKecilTest(string kalimat, string expected)
        {
            Assert.Equal(expected, TukarBesarKecil(kalimat));
        }
    }
}