// Week 04 - Exercise 10
// Cek AB
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-cek-ab.md

using System;
using System.Collections.Generic;

namespace hacktiv8_p0_csharp.Week04
{
    public class User1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }

        public User1(string firstName, string lastName, string gender, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = DateTime.Today.Year - birthYear;
        }

        public User1(string firstName, string lastName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public User1() { }
    }

    public class Exercise10
    {
        public static List<User1> ChangeMe(object arr)
        {
            return new List<User1>();
        }
    }
}