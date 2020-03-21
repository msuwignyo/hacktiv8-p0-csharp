using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week02.Exercise13;

namespace hacktiv8_p0_csharp.tests.Week02
{
    public class XOTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "xoxoxo", true };
            yield return new object[] { "oxooxo", false };
            yield return new object[] { "oxo", false };
            yield return new object[] { "xxxooo", true };
            yield return new object[] { "xoxooxxo", true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise13
    {
        [Theory]
        [ClassData(typeof(XOTestData))]
        public void XOTest(string input, bool expected)
        {
            Assert.Equal(expected, XO(input));
        }
    }
}
