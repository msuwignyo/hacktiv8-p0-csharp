// Week 03 - Exercise 13
// Target Terdekat
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-target-terdekat.md

using System;
using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise13
    {
        public static int TargetTerdekat(char[] arr)
        {
            var indexO = new Queue<int>();
            var indexX = new Queue<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals('o')) indexO.Enqueue(i);

                if (arr[i].Equals('x')) indexX.Enqueue(i);
            }

            var maxValue = int.MaxValue;
            foreach (var itemO in indexO)
            foreach (var itemX in indexX)
            {
                var temp = Math.Abs(itemO - itemX);
                if (temp < maxValue) maxValue = temp;
            }

            if (maxValue == int.MaxValue) return 0;

            return maxValue;
        }
    }
}