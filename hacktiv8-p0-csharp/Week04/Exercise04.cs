// Week 04 - Exercise 04
// Cari Modus
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cari-modus.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise04
    {
        public static int CariModus(int[] arr)
        {
            var freqTable = arr.Zip(arr.Select(item => arr.Count(item2 => item == item2)))
                .ToList();

            var maxFreq = freqTable.Max(item => item.Second);

            // kasus data uniform:
            // [7, 7, 7, 7, 7]
            if (maxFreq == freqTable.Count())
            {
                return -1;
            }

            var filteredList = freqTable.Where(item => item.Second == maxFreq).ToList();

            // kasus tiap item frekuensi-nya sama semua:
            // [10, 3, 1, 2, 5]
            if (filteredList.Count() == freqTable.Count)
            {
                return -1;
            }

            return filteredList.First().First;
        }
    }
}