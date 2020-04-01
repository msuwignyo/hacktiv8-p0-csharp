// Week 04 - Exercise 09
// Cek AB
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cek-ab.md

using System;
using System.Linq;
using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise09
    {
        public static bool CheckAB(string num)
        {
            var dict = new
            {
                locA = new List<int>(),
                locB = new List<int>()
            };

            var temp = num.ToCharArray();

            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case 'a':
                        dict.locA.Add(i);
                        break;
                    case 'b':
                        dict.locB.Add(i);
                        break;
                    default:
                        break;
                }
            }

            foreach (var itemA in dict.locA)
            {
                foreach (var itemB in dict.locB)
                {
                    if (Math.Abs(itemB - itemA) == 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}