// Week 04 - Exercise 06
// Digit Perkalian Minimum
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-digit-perkalian-minimum.md

using System.Collections.Generic;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise06
    {
        public static int DigitPerkalianMinimum(int angka)
        {
            if (angka == 1) return 2;

            var factors = new List<string>();

            for (var i = 1; i < angka / 2; i++)
                if (angka % i == 0)
                    factors.Add($"{i}{angka / i}");

            return factors.Min(item => item.Length);
        }
    }
}