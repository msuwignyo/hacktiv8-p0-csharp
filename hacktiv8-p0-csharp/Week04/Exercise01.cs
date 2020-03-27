// Week 04 - Exercise 01
// Angka Prima
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-angka-prima.md

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise01
    {
        public static bool AngkaPrima(int angka)
        {
            if (angka <= 1) return false;

            for (var i = 2; i < angka; i++)
                if (angka % i == 0)
                    return false;

            return true;
        }
    }
}