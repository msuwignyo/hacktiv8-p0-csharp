// Week 04 - Exercise 03
// Cari Median
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cari-median.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise03
    {
        public static double CariMedian(int[] arr)
        {
            var orderedArr = arr
                .OrderBy(item => item)
                .ToList();

            return orderedArr.Count % 2 == 0
                ? 0.5 * (orderedArr[orderedArr.Count / 2 - 1] +
                         orderedArr[orderedArr.Count / 2])
                : orderedArr[orderedArr.Count / 2];
        }
    }
}
