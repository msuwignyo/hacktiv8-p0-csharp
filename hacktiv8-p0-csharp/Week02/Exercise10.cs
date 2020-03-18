// Week 02 - Exercise 10
// Bandingkan Angka
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-bandingkan-angka.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise10
    {
        public static int BandingkanAngka(int angka1, int angka2)
        {
            if (angka1 < angka2)
            {
                return 1;
            }
            if (angka1 > angka2)
            {
                return 0;
            }

            return -1;
        }
    }
}
