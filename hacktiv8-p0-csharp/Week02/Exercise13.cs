// Week 02 - Exercise 13
// X dan O
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-x-dan-o.md

using System.Linq;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise13
    {
        public static bool XO(string str)
        {
            var freqTable = str.GroupBy(item => item,
                    (key,
                        result) => new
                    {
                        Character = key,
                        Total = result.Count()
                    })
                .ToDictionary(item => item.Character);

            return freqTable['x'].Total == freqTable['o'].Total;
        }
        
        // public static bool XO(string str)
        // {
        //     var countX = 0;
        //     var countO = 0;
        //
        //     foreach (var item in str)
        //     {
        //         if (item == 'x') countX++;
        //
        //         if (item == 'o') countO++;
        //     }
        //
        //     return countX == countO;
        // }
    }
}