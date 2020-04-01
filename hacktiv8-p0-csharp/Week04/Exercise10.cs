// Week 04 - Exercise 10
// Cek AB
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-object-literal.md
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class User1
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
    }

    public class Exercise10
    {
        public static List<User1> ChangeMe(List<Tuple<string, string, string, int?>> arr)
        {
            var result = new List<User1>();

            foreach (var user in arr)
            {
                var temp = new User1();

                var (FirstName, LastName, Gender, YearOfBirth) = user;

                temp.FirstName = FirstName;
                temp.LastName = LastName;
                temp.Gender = Gender;

                temp.Age = YearOfBirth == null
                    ? null
                    : DateTime.Now.Year - YearOfBirth;

                result.Add(temp);
            }

            return result;
        }
    }
}