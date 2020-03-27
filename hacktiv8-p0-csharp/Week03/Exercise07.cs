// Week 03 - Exercise 07
// Hitung Jumlah Kata
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-hitung-jumlah-kata.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise07
    {
        public static int HitungJumlahKata(string kalimat)
        {
            return kalimat.Split(" ").Count();
        }
    }
}