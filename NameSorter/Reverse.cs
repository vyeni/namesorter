using System;
using System.Collections.Generic;

namespace NameSorter
{
    public static class Reverse
    {
        /// <summary>
        /// Reverses an input, an input will "quick brown" will be reversed to "brown quick".
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Reversed line</returns>
        public static string InputString(string input)
        {
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = input.Split(new[] {
                " "
                }, StringSplitOptions.None);
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    result += words[i] + " ";
                }
                wordsList.Add(result);

            string ReversedName = "";
            foreach (String s in wordsList)
            {

                ReversedName += s;
            }
            return ReversedName;
        }
    }
}
