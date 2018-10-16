using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class SyllableFinder
    {
        static readonly char[] Vowels = new char[] { 'у', 'У', 'е', 'Е', 'ы', 'Ы', 'а', 'А', 'о', 'О', 'э', 'Э', 'я', 'Я', 'и', 'И', 'ю', 'Ю' };
        static readonly char[] exeptions = new char[] { 'р', 'л', 'м', 'н', 'й' };

        public static string DevideWord(this string word)
        {
            if (word.Length > 3)
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (IsVowel(word[i]))
                        if (exeptions.Contains(word[i + 1]) && i != word.Length - 2 && !IsVowel(word[i + 2]))
                        {
                            if (word[i + 2] != 'ь')
                                word = word.Insert(i + 2, "-");
                            else
                                if (i + 2 != word.Length - 1)
                                word = word.Insert(i + 3, "-");
                        }
                        else
                        {
                            if (!(!IsVowel(word[i + 1]) && i == word.Length - 2))
                                word = word.Insert(i + 1, "-");

                        }
                }
            return word;
        }

        private static bool IsVowel(char ch)
        {
            return Vowels.Contains(ch);
        }
    }
}
