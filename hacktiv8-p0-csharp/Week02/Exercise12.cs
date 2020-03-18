﻿// Week 02 - Exercise 12
// Konversi Menit
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-konversi-menit.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise12
    {
        public static string KonversiMenit(int menit)
        {
            int jam = menit / 60;
            int sisa = menit % 60;

            return $"{jam}:{sisa:D2}";
        }
    }
}
