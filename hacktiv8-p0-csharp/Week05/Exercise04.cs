// Week 05 - Exercise 04
// Total Digit Rekursif
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-total-digit.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise04
    {
        public static int TotalDigitRekursif(int angka)
        {
            if (angka < 10)
            {
                return angka;
            }

            var temp = angka.ToString();

            return int.Parse(temp[0].ToString()) 
                + TotalDigitRekursif(int.Parse(temp[1..temp.Length]));
        }
    }
}
