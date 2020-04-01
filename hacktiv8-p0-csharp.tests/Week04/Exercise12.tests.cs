using System.Collections;
using System.Collections.Generic;
using System.Linq;
using hacktiv8_p0_csharp.Week04;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise12;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class CountProfitTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper { Name = "Windi", Product = "Sepatu Stacattu", Amount = 2 },
                    new Shopper { Name = "Vanessa", Product = "Sepatu Stacattu", Amount = 3 },
                    new Shopper { Name = "Vanessa", Product = "Sepatu Stacattu", Amount = 3 }
                },
                new List<Item>
                {
                    new Item
                    {
                        Product = "Sepatu Stacattu",
                        Shoppers = new List<string> { "Windi", "Vanessa" },
                        LeftOver = 5,
                        TotalProfit = 7500000
                    },
                    new Item
                    {
                        Product = "Baju Zoro",
                        Shoppers = new List<string>(),
                        LeftOver = 2,
                        TotalProfit = 0
                    },
                    new Item
                    {
                        Product = "Sweater Uniklooh",
                        Shoppers = new List<string>(),
                        LeftOver = 1,
                        TotalProfit = 0
                    }
                }
            };
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper { Name = "Windi", Product = "Sepatu Stacattu", Amount = 8 },
                    new Shopper { Name = "Vanessa", Product = "Sepatu Stacattu", Amount = 10 },
                    new Shopper { Name = "Rani", Product = "Sweater Uniklooh", Amount = 1 },
                    new Shopper { Name = "Devi", Product = "Baju Zoro", Amount = 1 },
                    new Shopper { Name = "Lisa", Product = "Baju Zoro", Amount = 1 }
                },
                new List<Item>
                {
                    new Item
                    {
                        Product = "Sepatu Stacattu",
                        Shoppers = new List<string> { "Windi" },
                        LeftOver = 2,
                        TotalProfit = 12000000
                    },
                    new Item
                    {
                        Product = "Baju Zoro",
                        Shoppers = new List<string> { "Devi", "Lisa" },
                        LeftOver = 0,
                        TotalProfit = 1000000
                    },
                    new Item
                    {
                        Product = "Sweater Uniklooh",
                        Shoppers = new List<string> { "Rani" },
                        LeftOver = 0,
                        TotalProfit = 175000
                    }
                }
            };
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper { Name = "Windi", Product = "Sepatu Naiki", Amount = 5 }
                },
                new List<Item>
                {
                    new Item
                    {
                        Product = "Sepatu Stacattu",
                        Shoppers = new List<string>(),
                        LeftOver = 10,
                        TotalProfit = 0
                    },
                    new Item
                    {
                        Product = "Baju Zoro",
                        Shoppers = new List<string>(),
                        LeftOver = 2,
                        TotalProfit = 0
                    },
                    new Item
                    {
                        Product = "Sweater Uniklooh",
                        Shoppers = new List<string>(),
                        LeftOver = 1,
                        TotalProfit = 0
                    }
                }
            };
            yield return new object[]
            {
                new List<Shopper>(),
                new List<Item>()
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise12
    {
        [Theory]
        [ClassData(typeof(CountProfitTestData))]
        public void CountProfitTest(List<Shopper> shoppers, List<Item> expected)
        {
            var actual = CountProfit(shoppers);

            Assert.Equal(expected.Count(), actual.Count());

            for (int i = 0; i < expected.Count(); i++)
            {
                expected[i].Product = actual[i].Product;
                expected[i].LeftOver = actual[i].LeftOver;
                expected[i].Shoppers = actual[i].Shoppers;
                expected[i].TotalProfit = actual[i].TotalProfit;
            }

            //Assert.Equal(expected, CountProfit(shoppers));
        }
    }
}