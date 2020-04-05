using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise02;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class PasswordGeneratorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "Sergei Dragunov", "VPNVGBRdJFGRFs" };
            yield return new object[] { "Dimitri Wahyudiputra", "BRTVPJDVYHBwJRTJMJd" };
            yield return new object[] { "Alexei", "JFXFLb" };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise02
    {
        [Theory]
        [ClassData(typeof(PasswordGeneratorTestData))]
        public void PasswordGeneratorTest(string name, string expected)
        {
            Assert.Equal(expected, PasswordGenerator(name));
        }

        [Fact]
        public void PasswordGeneratorTestBelowMinimalChars()
        {
            var exception = Assert.Throws<Exception>(() =>
                PasswordGenerator("Alex"));

            Assert.Equal("Minimal karakter yang diinputkan adalah 5 karakter", exception.Message);
        }
    }
}