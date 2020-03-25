// Week 04 - Exercise 02
// Faktor Persekutuan Terbesar
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-faktor-persekutuan-terbesar.md

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise02
    {
        public static int FPB(int angka1, int angka2)
        {
            return angka2 == 0
                ? angka1
                : FPB(angka2, angka1 % angka2);
        }
    }
}
