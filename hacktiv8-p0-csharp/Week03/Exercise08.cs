// Week 03 - Exercise 08
// Pasangan Angka Terbesar
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-pasangan-terbesar.md
using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise08
    {
        public static int PasanganTerbesar(int num)
        {

            string str = num.ToString();
            int maxNum = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                int temp = Int32.Parse(str.Substring(i, 2));

                if (temp > maxNum)
                {
                    maxNum = temp;
                }
            }

            return maxNum;
        }
    }
}
