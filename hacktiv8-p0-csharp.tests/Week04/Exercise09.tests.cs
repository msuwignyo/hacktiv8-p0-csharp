using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise09;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class CheckABTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"lane borrowed", true};
            yield return new object[] {"i am sick", false};
            yield return new object[] {"you are boring", true};
            yield return new object[] {"barbarian", true};
            yield return new object[] {"bacon and meat", false};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise09
    {
        [Theory]
        [ClassData(typeof(CheckABTestData))]
        public void CheckABTest(string num, bool expected)
        {
            Assert.Equal(expected, CheckAB(num));
        }
    }
}