// Week 03 - Exercise 14
// Mengelompokkan Angka
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-kelompok-angka.md

using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise14
    {
        public static int[][] MengelompokkanAngka(int[] arr)
        {
            var even = new Queue<int>();
            var odd = new Queue<int>();
            var multipleOfThree = new Queue<int>();

            foreach (var item in arr)
                if (item % 3 == 0)
                    multipleOfThree.Enqueue(item);
                else if (item % 2 == 0)
                    even.Enqueue(item);
                else
                    odd.Enqueue(item);

            return new[]
            {
                even.ToArray(),
                odd.ToArray(),
                multipleOfThree.ToArray()
            };
        }
    }
}