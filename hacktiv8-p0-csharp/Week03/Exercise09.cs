// Week 03 - Exercise 09
// Cari Mean
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cari-mean.md

using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise09
    {
        public static double CariMean(int[] arr)
        {
            double total = 0;

            foreach (int item in arr)
            {
                total += item;
            }

            //int temp = total / arr.Length;
            return Math.Ceiling(total / arr.Length);
        }

        public static double CariMeanLinq(int[] arr)
        {
            return Math.Ceiling(arr.Average());
        }
    }
}
