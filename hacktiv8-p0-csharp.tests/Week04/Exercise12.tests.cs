using System.Collections;
using System.Collections.Generic;
using hacktiv8_p0_csharp.Week04;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise12;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class Item
    {
        public Item(string name, int stock, decimal profit, List<string> shoppers)
        {
            Name = name;
            Stock = stock;
            Profit = profit;
            Shoppers = shoppers;
        }

        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        public decimal Profit { get; set; }
        public List<string> Shoppers { get; set; }
    }

    public class CountProfitTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper("Windi", "Sepatu Stacattu", 2),
                    new Shopper("Vanessa", "Sepatu Stacattu", 3),
                    new Shopper("Rani", "Sweater Uniklooh", 2)
                },
                new List<Item>
                {
                    new Item("Sepatu Stacattu", 5, 7500000,
                        new List<string> {"Windi", "Vanessa"}),
                    new Item("Baju Zoro", 2, 0,
                        new List<string>()),
                    new Item("Sweater Uniklooh", 1, 0,
                        new List<string>())
                }
            };
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper("Windi", "Sepatu Stacattu", 8),
                    new Shopper("Vanessa", "Sepatu Stacattu", 10),
                    new Shopper("Rani", "Sweater Uniklooh", 1),
                    new Shopper("Devi", "Baju Zoro", 1),
                    new Shopper("Lisa", "Baju Zoro", 1)
                },
                new List<Item>
                {
                    new Item("Sepatu Stacattu", 2, 12000000,
                        new List<string> {"Windi"}),
                    new Item("Baju Zoro", 0, 1000000,
                        new List<string> {"Devi", "Lisa"}),
                    new Item("Sweater Uniklooh", 0, 175000,
                        new List<string> {"Rani"})
                }
            };
            yield return new object[]
            {
                new List<Shopper>
                {
                    new Shopper("Windi", "Sepatu Naiki", 5)
                },
                new List<Item>
                {
                    new Item("Sepatu Stacattu", 10, 0,
                        new List<string>()),
                    new Item("Baju Zoro", 2, 0,
                        new List<string>()),
                    new Item("Sweater Uniklooh", 1, 0,
                        new List<string>())
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
            Assert.Equal(expected, CountProfit(shoppers));
        }
    }
}