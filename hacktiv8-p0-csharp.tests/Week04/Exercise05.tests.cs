using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise05;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class UbahHurufTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"wow", "xpx"};
            yield return new object[] {"developer", "efwfmpqfs"};
            yield return new object[] {"javascript", "kbwbtdsjqu"};
            yield return new object[] {"keren", "lfsfo"};
            yield return new object[] {"semangat", "tfnbohbu"};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise05
    {
        [Theory]
        [ClassData(typeof(UbahHurufTestData))]
        public void UbahHurufTest(string kata, string expected)
        {
            Assert.Equal(expected, UbahHuruf(kata));
        }
    }
}