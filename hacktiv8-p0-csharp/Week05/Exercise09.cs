// Week 05 - Exercise 09
// Cari Pelaku
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cari-pelaku.md

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise09
    {
        public static int CariPelaku(string str)
        {
            const string pattern = @"abc";
            var result = Regex.Matches(str, pattern);
            
            return result.Count;
        }
    }
}
