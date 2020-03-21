// Week 03 - Exercise 12
// Deret Geometri
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-deret-geometri.md

using System;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise12
    {
        public static bool TentukanDeretGeometri(double[] arr)
        {
            bool flag = true;
            double scale = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (flag)
                {
                    scale = arr[i + 1] / arr[i];
                    flag = false;
                }

                double temp = arr[i + 1] / arr[i];
                if (Math.Abs(temp - scale) > Double.Epsilon)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
