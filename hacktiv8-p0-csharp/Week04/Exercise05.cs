// Week 04 - Exercise 05
// Ubah Huruf
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-ubah-huruf.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class Exercise05
    {
        public static string UbahHuruf(string kata)
        {
            return string.Join("",
                kata.Select(item => (char) (((int) item - 'a' + 1) % ('z' - 'a') + 'a')));
        }
    }
}