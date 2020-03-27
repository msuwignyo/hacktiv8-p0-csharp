using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week02.Exercise11;

namespace hacktiv8_p0_csharp.tests.Week02
{
    public class BalikKataTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"Hello World and Coders", "sredoC dna dlroW olleH"};
            yield return new object[] {"John Doe", "eoD nhoJ"};
            yield return new object[] {"I am a bookworm", "mrowkoob a ma I"};
            yield return new object[] {"Coding is my hobby", "ybboh ym si gnidoC"};
            yield return new object[] {"Super", "repuS"};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Exercise11
    {
        [Theory]
        [ClassData(typeof(BalikKataTestData))]
        public void BalikKataTest(string input, string expected)
        {
            Assert.Equal(expected, BalikKata(input));
        }
    }
}