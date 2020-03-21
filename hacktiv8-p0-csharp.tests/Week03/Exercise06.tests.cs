using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise06;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class AngkaPalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 8, 9 };
            yield return new object[] { 10, 11 };
            yield return new object[] { 117, 121 };
            yield return new object[] { 175, 181 };
            yield return new object[] { 1000, 1001 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise06
    {
        [Theory]
        [ClassData(typeof(AngkaPalindromeTestData))]
        public void AngkaPalindromeTest(int input, int expected)
        {
            Assert.Equal(expected, AngkaPalindrome(input));
        }
    }
}