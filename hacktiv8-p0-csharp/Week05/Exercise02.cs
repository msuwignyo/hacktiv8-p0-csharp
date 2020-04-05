// Week 05 - Exercise 02
// Password Generator
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-password-generator.md

using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise02
    {
        private static string ChangeVocals(string str)
        {
            var vocalChar = new char[]
            {
                'a', 'i', 'u', 'e', 'o',
                'A', 'i', 'U', 'E', 'O'
            };

            return string.Concat(str.Select(character =>
            {
                return vocalChar.Any(item => item == character)
                    ? (char) ((int) character + 1)
                    : character;
            }));
        }

        private static string ReverseWord(string str)
        {
            return string.Concat(str.Reverse());
        }

        private static string SetLowerUpperCase(string str)
        {
            return string.Concat(str.ToCharArray()
                .Select(item =>
                {
                    if (char.IsLower(item))
                    {
                        return char.ToUpper(item);
                    }

                    if (char.IsUpper(item))
                    {
                        return char.ToLower(item);
                    }

                    return item;
                }));
        }

        private static string RemoveSpaces(string str)
        {
            return string.Concat(str.ToCharArray()
                .Where(item => item != ' '));
        }

        public static string PasswordGenerator(string name)
        {
            if (name.Length < 5)
            {
                throw new Exception("Minimal karakter yang diinputkan adalah 5 karakter");
            }

            name = ChangeVocals(name);
            name = ReverseWord(name);
            name = SetLowerUpperCase(name);
            name = RemoveSpaces(name);

            return name;
        }
    }
}