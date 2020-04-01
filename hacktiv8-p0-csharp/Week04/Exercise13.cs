// Week 04 - Exercise 13
// Deep Sum
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-deep-sum.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise13
    {
        public static int DeepSum(int[][][] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("No number");
            }

            var result = 0;

            foreach (var item in arr)
            {
                foreach (var item2 in item)
                {
                    foreach (var item3 in item2)
                    {
                        result += item3;
                    }
                }
            }

            return result;
        }
    }
}
