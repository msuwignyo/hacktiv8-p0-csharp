// Week 05 - Exercise 02
// Password Generator
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-password-generator.md

using System;
using System.Linq;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise02
    {
        public static string ChangeVocals(string str)
        {
            var result = string.Empty;

            var vocalChar = new char[]
            {
                'a', 'i', 'u', 'e', 'o',
                'A', 'i', 'U', 'E', 'O'
            };

            foreach (var character in str)
            {
                result += vocalChar.Any(item => item == character)
                    ? (char)((int)character + 1)
                    : character;
            }

            return result;
        }

        public static string ReverseWord(string str)
        {
            return string.Concat(str.Reverse());
        }

        public static string SetLowerUpperCase(string str)
        {
            return string.Concat(
                str.ToCharArray()
                    .Select(item =>
                    {
                        if (Char.IsLower(item))
                        {
                            return Char.ToUpper(item);
                        }

                        if (Char.IsUpper(item))
                        {
                            return Char.ToLower(item);
                        }

                        return item;
                    }));
        }

        public static string RemoveSpaces(string str)
        {
            return string.Concat(
                str.ToCharArray()
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