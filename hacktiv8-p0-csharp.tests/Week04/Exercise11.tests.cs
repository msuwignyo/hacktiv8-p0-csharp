using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise11;
using hacktiv8_p0_csharp.Week04;
using System;
using System.Linq;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class ShoppingTimeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                "1820RzKrnWn08", 2475000,
                new User2
                {
                    MemberId = "1820RzKrnWn08",
                    Money = 2475000,
                    ListPurchased = new List<string>
                    {
                        "Sepatu Stacattu",
                        "Baju Zoro",
                        "Baju H&N",
                        "Sweater Uniklooh",
                        "Casing Handphone"
                    },
                    ChangeMoney = 0
                }
            };
            yield return new object[]
            {
                "82Ku8Ma742", 170000,
                new User2
                {
                    MemberId = "82Ku8Ma742",
                    Money = 170000,
                    ListPurchased = new List<string>
                    {
                        "Casing Handphone"
                    },
                    ChangeMoney = 120000
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise11
    {
        [Theory]
        [ClassData(typeof(ShoppingTimeTestData))]
        public void ShoppingTimeTest(string memberId, decimal money, User2 expected)
        {
            var actual = ShoppingTime(memberId, money);

            Assert.Equal(expected.Money, actual.Money);
            Assert.Equal(expected.MemberId, actual.MemberId);
            Assert.Equal(expected.ChangeMoney, actual.ChangeMoney);
            Assert.Equal(expected.ListPurchased, actual.ListPurchased);
        }

        [Fact]
        public void ShoppingTimeTestNoMemberId()
        {
            var exception = Assert.Throws<Exception>(() =>
                ShoppingTime("", 2475000));

            Assert.Equal("Mohon maaf, toko X hanya berlaku untuk member saja", exception.Message);
        }

        [Fact]
        public void ShoppingTimeTestInsufficientMoney()
        {
            var exception = Assert.Throws<Exception>(() =>
                ShoppingTime("234JdhweRxa53", 15000));

            Assert.Equal("Mohon maaf, uang tidak cukup", exception.Message);
        }

        [Fact]
        public void ShoppingTimeTestNoArgumentIsGiven()
        {
            var exception = Assert.Throws<Exception>(() =>
                ShoppingTime());

            Assert.Equal("Mohon maaf, toko X hanya berlaku untuk member saja", exception.Message);
        }
    }
}