// Week 05 - Exercise 01
// Most Frequent Largest Numbers
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-most-frequent-largest-numbers.md

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise01
    {
        private static IEnumerable<int> Sorting(IEnumerable<int> arrNumber)
        {
            return arrNumber.OrderBy(item => item).ToList();
        }

        private static string GetTotal(IEnumerable<int> arrNumber)
        {
            var arrNumberList = arrNumber.ToList();
            
            if (!arrNumberList.Any())
            {
                return string.Empty;
            }

            var highestNum = arrNumberList.Max();

            var freqHighestNum = arrNumberList.Count(item => 
                item == highestNum);

            return $"angka paling besar adalah {highestNum} dan jumlah kemunculan sebanyak {freqHighestNum} kali";
        }

        public static string MostFrequentLargestNumbers(IEnumerable<int> arrNumber)
        {
            var listSort = Sorting(arrNumber);
            var countHighest = GetTotal(listSort);
            return countHighest;
        }
    }
}
