using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Sample;

namespace hacktiv8_p0_csharp.tests
{
    public class ContohTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"Hello, world!"};
            yield return new object[] {"This is sample of my mistake"};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Sample
    {
        [Theory]
        [ClassData(typeof(ContohTestData))]
        public void ContohTest(string expected)
        {
            Assert.Equal(expected, Contoh());
        }
    }
}