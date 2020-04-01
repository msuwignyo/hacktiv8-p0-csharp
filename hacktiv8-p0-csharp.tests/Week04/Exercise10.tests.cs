using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise10;
using hacktiv8_p0_csharp.Week04;
using System.Linq;
using System;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class ChangeMeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<Tuple<string, string, string, int?>>
                {
                    new Tuple<string, string, string, int?>("Christ", "Evans", "Male", 1982),
                    new Tuple<string, string, string, int?>("Robert", "Downey", "Male", null),
                },
                new List<User1>
                {
                    new User1() { FirstName = "Christ", LastName = "Evans", Gender = "Male", Age = 38 },
                    new User1() { FirstName = "Robert", LastName = "Downey", Gender = "Male", Age = null }
                } 
            };
            yield return new object[]
            {
                new List<Tuple<string, string, string, int?>>(),
                new List<User1>() 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise10
    {
        [Theory]
        [ClassData(typeof(ChangeMeTestData))]
        public void ChangeMeTest(List<Tuple<string, string, string, int?>> arr, List<User1> expected)
        {
            var result = ChangeMe(arr);

            Assert.Equal(expected.Count(), result.Count());

            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.Equal(expected[i].FirstName, result[i].FirstName);
                Assert.Equal(expected[i].LastName, result[i].LastName);
                Assert.Equal(expected[i].Gender, result[i].Gender);
                Assert.Equal(expected[i].Age, result[i].Age);
            }
        }
    }
}