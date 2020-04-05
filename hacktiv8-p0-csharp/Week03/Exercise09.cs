// Week 03 - Exercise 09
// Cari Mean
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cari-mean.md

using System;
using System.Collections.Generic;
using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise09
    {
        public static double CariMean(IEnumerable<int> arr)
        {
            return Math.Ceiling(arr.Average());
        }
        
        // public static double CariMean(int[] arr)
        // {
        //     var total = arr.Aggregate<int, double>(0, (current, item) => current + item);
        //
        //     return Math.Ceiling(total / arr.Length);
        // }
    }
}