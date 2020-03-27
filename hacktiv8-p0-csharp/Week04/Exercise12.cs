// Week 04 - Exercise 12
// Toko X
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-toko-x.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
#nullable enable
        public decimal? Profit { get; set; }
        public List<Shopper>? Shoppers { get; set; }
#nullable disable

        public Item(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    public class Shopper
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
    }

    public class Exercise12
    {
        public static List<object> CountProfit(List<Shopper> shoppers)
        {
            var listBarang = new List<Item>
            {
                new Item("Sepatu Stacattu", 1500000, 10),
                new Item("Baju Zoro", 500000, 2),
                new Item("Sweater Uniklooh", 175000, 1)
            };

            return new List<object>();
        }
    }
}
