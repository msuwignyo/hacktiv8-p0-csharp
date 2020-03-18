// Week 03 - Exercise 11
// Deret Aritmatika
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-deret-aritmatika.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise11
    {
        public static bool TentukanDeretAritmatika(int[] arr)
        {
            bool flag = true;
            int selisih = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (flag)
                {
                    selisih = arr[i + 1] - arr[i];
                    flag = false;
                }

                int temp = arr[i + 1] - arr[i];
                if (temp != selisih)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
