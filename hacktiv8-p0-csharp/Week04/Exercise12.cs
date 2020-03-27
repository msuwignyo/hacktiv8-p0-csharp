// Week 04 - Exercise 12
// Toko X
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-toko-x.md

#nullable enable
using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week04
{
    public class Item
    {
        public Item(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal? Profit { get; set; }
        public List<string>? Shoppers { get; set; }
    }

    public class Shopper
    {
        public Shopper(string name, string product, int amount)
        {
            Name = name;
            Product = product;
            Amount = amount;
        }

        private string Name { get; set; }
        private string Product { get; set; }
        private int Amount { get; set; }
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
            
            // TODO: kerjakan exercise 12!

            return new List<object>();
        }
    }
}