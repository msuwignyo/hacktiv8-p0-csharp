// Week 02 - Exercise 11
// Balik Kata
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-balik-kata.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise11
    {
        public static string BalikKata(string kata)
        {
            return string.Concat(kata.Reverse());
        }
        
        // public static string BalikKata(string kata)
        // {
        //     var result = string.Empty;
        //
        //     for (var i = 0; i < kata.Length; i++)
        //     {
        //         result += kata[kata.Length - 1 - i];
        //     }
        //
        //     return result;
        // }
    }
}