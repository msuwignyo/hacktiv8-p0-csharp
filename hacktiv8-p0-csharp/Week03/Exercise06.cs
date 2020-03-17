using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hacktiv8_p0_csharp.Week03
{
    public class Exercise06
    {
        static bool IsPalindrome(int num)
        {
            string temp = num.ToString();
            string numReverse = String.Empty;

            for (int i = 0; i < temp.Length; i++)
            {
                numReverse += temp[temp.Length - 1 - i];
            }

            return numReverse == temp;
        }

        static bool IsPalindromeLinq(int num)
        {
            string temp = num.ToString();

            return String.Concat(temp.Reverse()) == temp;
        }

        public static int AngkaPalindrome(int num)
        {
            // TODO: https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-palindrome-angka.md

            num++;
            while (!IsPalindrome(num))
            {
                num++;
            }

            return num;
        }
    }
}
