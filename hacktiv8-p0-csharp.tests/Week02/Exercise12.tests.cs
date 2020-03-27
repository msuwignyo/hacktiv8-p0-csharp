using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week02.Exercise12;

namespace hacktiv8_p0_csharp.tests.Week02
{
    public class KonversiMenitTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {63, "1:03"};
            yield return new object[] {124, "2:04"};
            yield return new object[] {53, "0:53"};
            yield return new object[] {88, "1:28"};
            yield return new object[] {120, "2:00"};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise12
    {
        [Theory]
        [ClassData(typeof(KonversiMenitTestData))]
        public void KonversiMenitTest(int input, string expected)
        {
            Assert.Equal(expected, KonversiMenit(input));
        }
    }
}