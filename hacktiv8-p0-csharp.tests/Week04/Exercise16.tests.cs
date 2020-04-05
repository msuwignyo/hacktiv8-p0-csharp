using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise16;
using hacktiv8_p0_csharp.Week04;
using System;
using System.Linq;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class GraduatesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<User4>
                {
                    new User4
                    {
                        Name = "Dimitri",
                        Score = 90,
                        Class = "foxes"
                    },
                    new User4
                    {
                        Name = "Alexei",
                        Score = 85,
                        Class = "wolves"
                    },
                    new User4
                    {
                        Name = "Sergei",
                        Score = 74,
                        Class = "foxes"
                    },
                    new User4
                    {
                        Name = "Anastasia",
                        Score = 78,
                        Class = "wolves"
                    }
                },
                new Dictionary<string,List<(string, int)>>
                {
                    { "foxes", 
                        new List<(string, int)> { ("Dimitri", 90) } },
                    { "wolves", 
                        new List<(string, int)> { ("Alexei", 85), ("Anastasia", 78) } }
                }
            };
            yield return new object[]
            {
                new List<User4>
                {
                    new User4
                    {
                        Name = "Alexander",
                        Score = 100,
                        Class = "foxes"
                    },
                    new User4
                    {
                        Name = "Alisa",
                        Score = 76,
                        Class = "wolves"
                    },
                    new User4
                    {
                        Name = "Vladimir",
                        Score = 92,
                        Class = "foxes"
                    },
                    new User4
                    {
                        Name = "Albert",
                        Score = 71,
                        Class = "wolves"
                    },
                    new User4
                    {
                        Name = "Viktor",
                        Score = 80,
                        Class = "tigers"
                    }
                },
                new Dictionary<string, List<(string, int)>>
                {
                    { "foxes",
                        new List<(string, int)> { ("Alexander", 100), ("Vladimir", 92) } },
                    { "wolves",
                        new List<(string, int)> { ("Alisa", 76) } },
                    { "tigers",
                        new List<(string, int)> { ("Viktor", 80) } }
                }
            };
            yield return new object[]
            {
                new List<User4>(),
                new Dictionary<string, List<(string, int)>>()
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise16
    {
        [Theory]
        [ClassData(typeof(GraduatesTestData))]
        public void GraduatesTest(List<User4> students, Dictionary<string, List<(string, int)>> expected)
        {
            var actual = Graduates(students);

            Assert.Equal(expected.Count(), actual.Count());

            var expectedKeys = expected.Keys;

            foreach (var key in expectedKeys)
            {
                Assert.True(actual.ContainsKey(key));
                Assert.Equal(expected[key].Count(), actual[key].Count());

                for (int i = 0; i < expected[key].Count(); i++)
                {
                    Assert.Equal(expected[key][i], actual[key][i]);
                }
            }
        }
    }
}