using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hacktiv8_p0_csharp.Week02
{
    public class Exercise13
    {
        public static bool XO(string str)
        {
            // TODO: https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-x-dan-o.md

            int countX = 0;
            int countO = 0;

            foreach (char item in str)
            {
                switch (item)
                {
                    case 'x':
                        countX++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    default:
                        break;
                }
            }

            return countX == countO;
        }

        public static bool XOLinq(string str)
        {
            var freqTable = str.GroupBy(item => item, (key, result) => new
            {
                Character = key,
                Total = result.Count()
            }).ToDictionary(item => item.Character);

            return freqTable['x'].Total == freqTable['o'].Total;
        }
    }
}
