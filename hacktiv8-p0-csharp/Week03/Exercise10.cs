// Week 02 - Exercise 10
// Perkalian Unik
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-perkalian-unik.md

using System.Collections.Generic;
using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise10
    {
        public static int[] PerkalianUnik(int[] arr)
        {
            var queue = new Queue<int>(arr);
            var result = new Queue<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                // selalu ambil elemen pertama
                var temp = queue.Dequeue();

                // kalikan elemen yang tersisa
                var buff = queue.Aggregate((total, next) => total * next);

                // masukkan hasil ke result
                result.Enqueue(buff);

                // elemen pertama dimasukkan lagi ke belakang
                queue.Enqueue(temp);
            }

            return result.ToArray();
        }
    }
}