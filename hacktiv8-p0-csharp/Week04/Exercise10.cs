// Week 04 - Exercise 10
// Cek AB
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cek-ab.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week04
{
    public class UserEx10
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }

    public class Exercise10
    {
        public static List<UserEx10> ChangeMe(object arr)
        {
            return new List<UserEx10>();
        }
    }
}
