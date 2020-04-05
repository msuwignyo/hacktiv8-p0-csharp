using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week05.Exercise06;

namespace hacktiv8_p0_csharp.tests.Week05
{
    public class DamageCalculationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 9, 25, 207 };
            yield return new object[] { 10, 4, 20 };
            yield return new object[] { 5, 20, 90 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise06
    {
        [Theory]
        [ClassData(typeof(DamageCalculationTestData))]
        public void DamageCalculationTest(int numberOfAttacks, int damagePerAttack, int expected)
        {
            Assert.Equal(expected, DamageCalculation(numberOfAttacks, damagePerAttack));
        }
    }
}