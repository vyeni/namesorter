using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class MergeSort
    {
        /// <summary>
        /// Gets the mid point of provided input.
        /// </summary>
        /// <param name="unsorted">input</param>
        /// <returns></returns>
        public static List<String> MergeInputs(List<String> unsorted)
        {

            if (unsorted.Count <= 1)
                return unsorted;

            List<String> left = new List<String>();
            List<String> right = new List<String>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeInputs(left);
            right = MergeInputs(right);
            return Merge(left, right);
        }

        /// <summary>
        /// Sorts through a list of string.
        /// </summary>
        /// <param name="left">Left half input</param>
        /// <param name="right">Right half of the input</param>
        /// <returns>sorted list of strings</returns>
        private static List<String> Merge(List<String> left, List<String> right)
        {
            List<String> result = new List<String>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    //Comparing first word two lines and to check which is smaller
                    if (CompareWords.IsLeftWordSmaller(left[0].TrimStart().TrimEnd().Split(' ')[0],
                        right[0].TrimStart().TrimEnd().Split(' ')[0]))
                    {
                        result.Add(left.First());

                        //Rest of the list minus the first element
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

    }
}
