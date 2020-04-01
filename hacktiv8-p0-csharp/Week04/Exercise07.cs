// Week 04 - Exercise 07
// Urutkan Abjad
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-urutkan-abjad.md

using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise07
    {
        public static string UrutkanAbjad(string str)
        {
            return String.Concat(str.ToCharArray().OrderBy(ch => ch));
        }
    }
}