// Week 04 - Exercise 13
// Deep Sum
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-deep-sum.md

using System;
using System.Collections.Generic;
using System.Linq;
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

            return arr.Sum(item => item.Sum(item2 => item2.Sum()));
        }
    }
}
