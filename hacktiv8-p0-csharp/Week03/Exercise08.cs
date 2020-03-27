// Week 03 - Exercise 08
// Pasangan Angka Terbesar
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-pasangan-terbesar.md

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise08
    {
        public static int PasanganTerbesar(int num)
        {
            var str = num.ToString();
            var maxNum = 0;

            for (var i = 0; i < str.Length - 1; i++)
            {
                var temp = int.Parse(str.Substring(i, 2));

                if (temp > maxNum) maxNum = temp;
            }

            return maxNum;
        }
    }
}