using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise05;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class PalindromeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "katak", true };
            yield return new object[] { "blanket", false };
            yield return new object[] { "civic", true };
            yield return new object[] { "kasur rusak", true };
            yield return new object[] { "mister", false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise05
    {
        [Theory]
        [ClassData(typeof(PalindromeTestData))]
        public void PalindromeTest(string input, bool expected)
        {
            Assert.Equal(expected, Palindrome(input));
        }
    }
}