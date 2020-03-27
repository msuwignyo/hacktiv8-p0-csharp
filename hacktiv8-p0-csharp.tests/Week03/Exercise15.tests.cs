using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week03.Exercise15;

namespace hacktiv8_p0_csharp.tests.Week03
{
    public class GroupAnimalsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {"cacing", "ayam", "kuda", "anoa", "kancil"},
                new[]
                {
                    new[] {"ayam", "anoa"},
                    new[] {"cacing"},
                    new[] {"kuda", "kancil"}
                }
            };
            yield return new object[]
            {
                new[]
                {
                    "cacing", "ayam", "kuda", "anoa", "kancil", "unta",
                    "cicak"
                },
                new[]
                {
                    new[] {"ayam", "anoa"},
                    new[] {"cacing", "cicak"},
                    new[] {"kuda", "kancil"},
                    new[] {"unta"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise15
    {
        [Theory]
        [ClassData(typeof(GroupAnimalsTestData))]
        public void GroupAnimalsTest(string[] input, string[][] expected)
        {
            Assert.Equal(expected, GroupAnimals(input));
        }
    }
}