using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise07;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class HitungJumlahKataTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"I have a dream", 4};
            yield return new object[] {"Never eat shredded wheat or cake", 6};
            yield return new object[] {"A song to sing", 4};
            yield return new object[] {"I", 1};
            yield return new object[] {"I believe I can code", 5};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise07
    {
        [Theory]
        [ClassData(typeof(HitungJumlahKataTestData))]
        public void HitungJumlahKataTest(string input, int expected)
        {
            Assert.Equal(expected, HitungJumlahKata(input));
        }
    }
}