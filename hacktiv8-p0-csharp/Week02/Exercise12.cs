// Week 02 - Exercise 12
// Konversi Menit
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-konversi-menit.md

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise12
    {
        public static string KonversiMenit(int menit)
        {
            var jam = menit / 60;
            var sisa = menit % 60;

            return $"{jam}:{sisa:D2}";
        }
    }
}