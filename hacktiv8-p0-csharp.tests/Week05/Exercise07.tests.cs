using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise07;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class MeleeRangedGroupingTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "Razor-Ranged,Invoker-Ranged,Meepo-Melee,Axe-Melee,Sniper-Ranged",
                new List<List<string>>
                {
                    new List<string> { "Razor", "Invoker", "Sniper" },
                    new List<string> { "Meepo", "Axe" }
                }
            };
            yield return new object[]
            {
                "Drow Ranger-Ranged,Chen-Ranged,Dazzle-Ranged,Io-Ranged",
                new List<List<string>>
                {
                    new List<string> { "Drow Ranger", "Chen", "Dazzle", "Io" },
                    new List<string>()
                }
            };
            yield return new object[]
            {
                "",
                new List<List<string>>()
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise07
    {
        [Theory]
        [ClassData(typeof(MeleeRangedGroupingTestData))]
        public void MeleeRangedGroupingTest(string str, List<List<string>> expected)
        {
            Assert.Equal(expected, MeleeRangedGrouping(str));
        }
    }
}