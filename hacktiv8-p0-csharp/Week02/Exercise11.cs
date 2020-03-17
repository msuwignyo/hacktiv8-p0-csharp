using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise11
    {
        public static string BalikKata(string kata)
        {
            // TODO: https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-balik-kata.md

            string result = String.Empty;

            for (int i = 0; i < kata.Length; i++)
            {
                result += kata[kata.Length - 1 - i];
            }

            return result;
        }

        public static string BalikKataLinq(string kata)
        {
            return String.Concat(kata.Reverse());
        }
    }
}