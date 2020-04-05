// Week 05 - Exercise 03
// Makan Terus Rekursif
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-makan-terus.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise03
    {
        public static int MakanTerusRekursif(int waktu)
        {
            if (waktu <= 0)
            {
                return 0;
            }

            return 1 + MakanTerusRekursif(waktu - 15);
        }
    }
}
