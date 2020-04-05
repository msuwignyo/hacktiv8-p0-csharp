// Week 05 - Exercise 07
// Melee Ranged Grouping
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-melee-ranged-grouping.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise07
    {
        public static List<List<string>> MeleeRangedGrouping(string str)
        {
            if (str.Length == 0)
            {
                return new List<List<string>>();
            }

            var heroes = str.Split(',');

            var result = new List<List<string>>
            {
                new List<string>(), // ranged heroes only
                new List<string>()  // melee heroes only
            };

            foreach (var hero in heroes)
            {
                var temp = hero.Split('-');

                if (temp[1] == "Ranged")
                {
                    result[0].Add(temp[0]);
                }

                if (temp[1] == "Melee")
                {
                    result[1].Add(temp[0]);
                }
            }

            return result;
        }
    }
}
