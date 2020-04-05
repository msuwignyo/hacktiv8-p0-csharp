// Week 05 - Exercise 08
// Hapus Simbol
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-hapus-simbol.md

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise08
    {
        public static string HapusSimbol(string str)
        {
            const string pattern = @"\W";
            return Regex.Replace(str, pattern, @"");
        }
    }
}
