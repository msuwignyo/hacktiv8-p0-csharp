// Week 03 - Exercise 05
// Palindrome
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-palindrome.md

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise05
    {
        public static bool Palindrome(string kata)
        {

            string temp = String.Empty;

            for (int i = 0; i < kata.Length; i++)
            {
                temp += kata[kata.Length - 1 - i];
            }

            return kata == temp;
        }

        public static bool PalindromeLinq(string kata)
        {
            return String.Concat(kata.Reverse()) == kata;
        }
    }
}
