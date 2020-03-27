// Week 04 - Exercise 11
// Shopping Time!
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-shopping-time.md

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

    public class Exercise11
    {
        public static User2 ShoppingTime(string memberId, decimal money)
        {
            return new User2();
        }
    }
}