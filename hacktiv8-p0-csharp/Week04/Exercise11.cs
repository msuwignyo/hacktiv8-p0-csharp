// Week 04 - Exercise 11
// Shopping Time!
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-shopping-time.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class UserEx11
    {
        public string MemberId { get; set; }
        public decimal Money { get; set; }
        public List<string> ListPurchased { get; set; }
        public decimal ChangeMoney { get; set; }
    }

    public class Exercise11
    {
        public static UserEx11 ShoppingTime(string memberId, decimal money)
        {
            return new UserEx11();
        }
    }
}
