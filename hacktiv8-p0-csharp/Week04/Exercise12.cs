// Week 04 - Exercise 12
// Toko X
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-toko-x.md

using System.Collections.Generic;
using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Item
    {
        public string Product { get; set; }
        public List<string> Shoppers { get; set; }
        public int LeftOver { get; set; }
        public decimal TotalProfit { get; set; }
    }

    public class Shopper
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
    }

    public class Exercise12
    {
        public static List<Item> CountProfit(IEnumerable<Shopper> shoppers)
        {
            var shopperList = shoppers.ToList();
            if (!shopperList.Any())
            {
                return new List<Item>();
            }

            var listBarang = new List<Tuple<string, decimal, int>>
            {
                new Tuple<string, decimal, int>("Sepatu Stacattu", 1500000m, 10),
                new Tuple<string, decimal, int>("Baju Zoro", 500000m, 2),
                new Tuple<string, decimal, int>("Sweater Uniklooh", 175000m, 1)
            };

            var result = new List<Item>();

            foreach (var barang in listBarang)
            {
                var (product, _, leftOver) = barang;

                result.Add(new Item
                {
                    Product = product,
                    Shoppers = new List<string>(),
                    LeftOver = leftOver,
                    TotalProfit = 0,
                });
            }

            foreach (var shopper in shopperList)
            {
                for (var i = 0; i < result.Count(); i++)
                {
                    if (result[i].Product != shopper.Product || result[i].LeftOver - shopper.Amount < 0)
                    {
                        continue;
                    }

                    result[i].LeftOver -= shopper.Amount;
                    result[i].Shoppers?.Add(shopper?.Name);
                    result[i].TotalProfit += listBarang[i].Item2 * shopper.Amount;
                }
            }

            return result;
        }
    }
}