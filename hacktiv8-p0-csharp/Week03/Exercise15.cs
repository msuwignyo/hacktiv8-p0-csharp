// Week 03 - Exercise 15
// Mengelompokkan Hewan
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-kelompok-hewan.md

using System.Collections.Generic;
using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise15
    {
        public static string[][] GroupAnimals(IEnumerable<string> animals)
        {
            return animals.OrderBy(animal => animal[0])
                .GroupBy(animal => animal[0],
                    (key,
                        result) => result.ToArray())
                .ToArray();
        }
    }
}