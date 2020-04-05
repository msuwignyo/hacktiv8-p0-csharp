using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise01;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class MostFrequentLargestNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<int> { 2, 8, 4, 6, 8, 5, 8, 4 },
                "angka paling besar adalah 8 dan jumlah kemunculan sebanyak 3 kali"
            };
            yield return new object[]
            {
                new List<int> { 122, 122, 130, 100, 135, 100, 135, 150 },
                "angka paling besar adalah 150 dan jumlah kemunculan sebanyak 1 kali"
            };
            yield return new object[]
            {
                new List<int> { 1, 1, 1, 1 },
                "angka paling besar adalah 1 dan jumlah kemunculan sebanyak 4 kali"
            };
            yield return new object[]
            {
                new List<int>(),
                string.Empty
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise01
    {
        [Theory]
        [ClassData(typeof(MostFrequentLargestNumbersTestData))]
        public void MostFrequentLargestNumbersTest(List<int> arrNumber, string expected)
        {
            Assert.Equal(expected, MostFrequentLargestNumbers(arrNumber));
        }
    }
}