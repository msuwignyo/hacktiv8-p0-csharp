using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise10;
using hacktiv8_p0_csharp.Week04;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class ChangeMeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<User1>
                {
                    new User1("Christ", "Evans", "Male", 1982),
                    new User1("Robert", "Downey", "Male")
                },
                new List<User1>
                {
                    new User1() {FirstName = "Chirst", LastName = "Evans", Gender = "Male", Age = 38},
                    new User1() {FirstName = "Robert", LastName = "Downey", Gender = "Male", Age = null}
                } 
            };
            yield return new object[]
            {
                new List<User1>(),
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
        public void ChangeMeTest(List<User1> arr, List<User1> expected)
        {
            Assert.Equal(expected, ChangeMe(arr));
        }
    }
}