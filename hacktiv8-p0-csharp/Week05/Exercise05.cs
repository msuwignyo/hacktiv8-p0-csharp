// Week 05 - Exercise 05
// Kali Terus Rekursif
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-kali-terus.md

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise05
    {
        public static int KaliTerusRekursif(int angka)
        {
            var result = angka.ToString()
                .Aggregate(1, (acc, item) =>
                    acc * int.Parse(item.ToString()));

            return angka < 10
                ? result
                : KaliTerusRekursif(result);
        }
    }
}
