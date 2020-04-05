// Week 04 - Exercise 16
// Graduates
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-graduates.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class User4
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Class { get; set; }
    }

    public class Exercise16
    {
        public static Dictionary<string, List<(string, int)>> Graduates(List<User4> students)
        {
            var temp = new Dictionary<string, List<(string, int)>>();

            foreach (var student in students)
            {
                if (!temp.ContainsKey(student.Class))
                {
                    temp[student.Class] = new List<(string, int)>();
                }

                if (student.Score > 75)
                {
                    temp[student.Class].Add((student.Name, student.Score));
                }
            }

            return temp;
        }
    }
}
