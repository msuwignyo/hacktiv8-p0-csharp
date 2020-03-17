using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise07
    {
        public static int HitungJumlahKata(string kalimat)
        {
            // TODO: https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-hitung-jumlah-kata.md

            return kalimat.Split(" ").Count();
        }
    }
}
