// Week 03 - Exercise 13
// Target Terdekat
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-target-terdekat.md

using System;
using System.Collections.Generic;
using System.Linq;

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
                if (arr[i].Equals('o'))
                {
                    indexO.Enqueue(i);
                }

                if (arr[i].Equals('x'))
                {
                    indexX.Enqueue(i);
                }
            }

            var maxValue = indexO.Aggregate(int.MaxValue,
                (current,
                    itemO) => indexX.Select(itemX => Math.Abs(itemO - itemX))
                    .Concat(new[]
                    {
                        current
                    })
                    .Min());


            return maxValue == int.MaxValue
                ? 0
                : maxValue;
        }
    }
}