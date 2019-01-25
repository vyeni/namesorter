using System;
using System.Text;

namespace NameSorter
{ /// <summary>
  /// Compare 2 words for sorting.
  /// </summary>
    public static class CompareWords
    {
        /// <summary>
        /// Compares 2 words based on their ASCII code
        /// </summary>
        /// <param name="left">word on left</param>
        /// <param name="right">right word</param>
        /// <returns>when left-word weights lighter than right word,  return false else return true</returns>
        public static bool IsLeftWordSmaller(String left, String right)
        {
            int count = 0;

            // Pick the length of the smaller word for comparision purpose.
            if (left.Length > right.Length)
                count = right.Length;
            else
                count = left.Length;

            // Convert to smaller case, because ASCII value of "A" is different than ASCII of "a".
            left = left.ToLower();
            right = right.ToLower();

            for (int i = 0; i < count; i++)
            {
                if (SumOfAscii(Encoding.ASCII.GetBytes(new[] { left[i] })) > SumOfAscii(Encoding.ASCII.GetBytes(new[] { right[i] })))
                {
                    return false;
                }
                if (SumOfAscii(Encoding.ASCII.GetBytes(new[] { left[i] })) < SumOfAscii(Encoding.ASCII.GetBytes(new[] { right[i] })))
                {
                    return true;
                }

                // This check to ensure scenarios like aa and aaa, aa should weight lighter than aaa
                if ((i == count - 1) && (left.Length > right.Length))
                {
                    return false;
                }
            }

            // else return true
            return true;
        }

        /// <summary>
        /// Sum of Ascii value 
        /// </summary>
        /// <param name="ascii">ascii byte array</param>
        /// <returns>sum as integer</returns>
        private static int SumOfAscii(byte[] ascii)
        {
            int summation = 0;
            foreach (var i in ascii)
            {
                summation = i + summation;
            }
            return summation;
        }


    }
}
