// Week 03 - Exercise 06
// Palindrome Angka
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-palindrome-angka.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise06
    {
        private static bool IsPalindrome(int num)
        {
            var temp = num.ToString();
            var numReverse = string.Empty;

            for (var i = 0; i < temp.Length; i++) numReverse += temp[temp.Length - 1 - i];

            return numReverse == temp;
        }

        private static bool IsPalindromeLinq(int num)
        {
            var temp = num.ToString();

            return string.Concat(temp.Reverse()) == temp;
        }

        public static int AngkaPalindrome(int num)
        {
            num++;
            while (!IsPalindrome(num)) num++;

            return num;
        }
    }
}