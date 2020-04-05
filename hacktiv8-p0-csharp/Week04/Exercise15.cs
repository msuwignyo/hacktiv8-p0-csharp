// Week 04 - Exercise 15
// Highest Score
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-highest-score.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class User3
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Class { get; set; }
    }

    public class Exercise15
    {
        public static Dictionary<string, (string, int)> HighestScore(List<User3> students)
        {
            var temp = new Dictionary<string, (string, int)>();

            foreach (var item in students)
            {
                if (temp.ContainsKey(item.Class))
                {
                    var (_, score) = temp[item.Class];
                    
                    if (item.Score > score)
                    {
                        temp[item.Class] = (item.Name, item.Score);
                    }
                }
                else
                {
                    temp[item.Class] = (item.Name, item.Score);
                }
            }

            return temp;
        }
    }
}
