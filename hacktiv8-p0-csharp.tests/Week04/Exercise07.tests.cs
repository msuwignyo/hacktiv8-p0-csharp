using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise07;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class UrutkanAbjadTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"hello", "ehllo"};
            yield return new object[] {"truncate", "acenrttu"};
            yield return new object[] {"developer", "deeeloprv"};
            yield return new object[] {"software", "aeforstw"};
            yield return new object[] {"aegis", "aegis"};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise07
    {
        [Theory]
        [ClassData(typeof(UrutkanAbjadTestData))]
        public void UrutkanAbjadTest(string str, string expected)
        {
            Assert.Equal(expected, UrutkanAbjad(str));
        }
    }
}