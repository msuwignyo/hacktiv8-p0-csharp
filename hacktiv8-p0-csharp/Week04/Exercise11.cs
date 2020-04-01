// Week 04 - Exercise 11
// Shopping Time!
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-shopping-time.md

using System;
using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week04
{
    public class User2
    {
        public string MemberId { get; set; }
        public decimal Money { get; set; }
        public List<string> ListPurchased { get; set; }
        public decimal ChangeMoney { get; set; }
    }

    public class ShopItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Exercise11
    {
        public static List<ShopItem> itemList = new List<ShopItem>
        {
            new ShopItem { Name = "Sepatu Stacattu", Price =  1500000 },
            new ShopItem { Name = "Baju Zoro", Price = 500000 },
            new ShopItem { Name = "Baju H&N", Price = 250000 },
            new ShopItem { Name = "Sweater Uniklooh", Price = 175000 },
            new ShopItem { Name = "Casing Handphone", Price = 50000 }
        };

        public static User2 ShoppingTime(string memberId, decimal money)
        {
            if (memberId.Length == 0)
            {
                throw new Exception("Mohon maaf, toko X hanya berlaku untuk member saja");
            }

            if (money < 50000)
            {
                throw new Exception("Mohon maaf, uang tidak cukup");
            }

            var user = new User2
            {
                MemberId = memberId,
                Money = money
            };

            var listPurchased = new List<string>();

            foreach (var item in itemList)
            {
                if (money >= item.Price)
                {
                    listPurchased.Add(item.Name);
                    money -= item.Price;
                }
            }

            user.ListPurchased = listPurchased;
            user.ChangeMoney = money;

            return user;
        }

        public static User2 ShoppingTime()
        {
            throw new Exception("Mohon maaf, toko X hanya berlaku untuk member saja");
        }
    }
}