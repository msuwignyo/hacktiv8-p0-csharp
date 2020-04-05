using hacktiv8_p0_csharp.Week04;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise15;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class HighestScoreTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<User3>
                {
                    new User3
                    {
                        Name = "Dimitri",
                        Score = 90,
                        Class = "foxes"
                    },
                    new User3
                    {
                        Name = "Alexei",
                        Score = 85,
                        Class = "wolves"
                    },
                    new User3
                    {
                        Name = "Sergei",
                        Score = 74,
                        Class = "foxes"
                    },
                    new User3
                    {
                        Name = "Anastasia",
                        Score = 78,
                        Class = "wolves"
                    }
                },
                new Dictionary<string, (string, int)>
                {
                    { "foxes", ("Dimitri", 90) },
                    { "wolves", ("Alexei", 85) }
                }
            };
            yield return new object[]
            {
                new List<User3>
                {
                    new User3
                    {
                        Name = "Alexander",
                        Score = 100,
                        Class = "foxes"
                    },
                    new User3
                    {
                        Name = "Alisa",
                        Score = 76,
                        Class = "wolves"
                    },
                    new User3
                    {
                        Name = "Vladimir",
                        Score = 92,
                        Class = "foxes"
                    },
                    new User3
                    {
                        Name = "Albert",
                        Score = 71,
                        Class = "wolves"
                    },
                    new User3
                    {
                        Name = "Viktor",
                        Score = 80,
                        Class = "tigers"
                    } 
                },
                new Dictionary<string, (string, int)>
                {
                    { "foxes", ("Alexander", 100) },
                    { "wolves", ("Alisa", 76) },
                    { "tigers", ("Viktor", 80) }
                }
            };
            yield return new object[]
            {
                new List<User3>(),
                new Dictionary<string, (string, int)>()
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
        [ClassData(typeof(HighestScoreTestData))]
        public void HighestScoreTest(List<User3> students, Dictionary<string,(string, int)> expected)
        {
            var actual = HighestScore(students);

            Assert.Equal(expected.Count(), actual.Count());

            var expectedKeys = expected.Keys;

            foreach (var key in expectedKeys)
            {
                Assert.True(actual.ContainsKey(key));
                Assert.Equal(expected[key], actual[key]);
            }
        }
    }
}