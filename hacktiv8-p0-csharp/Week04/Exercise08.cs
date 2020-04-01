// Week 04 - Exercise 08
// Tukar Ukuran
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-tukar-besar-kecil.md

using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise08
    {
        public static string TukarBesarKecil(string kalimat)
        {
            return String.Concat(
                kalimat.ToCharArray().Select(ch =>
                    Char.IsUpper(ch)
                        ? Char.ToLower(ch)
                        : char.ToUpper(ch)));
        }
    }
}