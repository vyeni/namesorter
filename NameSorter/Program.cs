using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    class Program
    {
        /// <summary>
        /// Program to sort a list of names given in a text file.
        /// </summary>
        /// <param name="args">Path to the unsorted-names-list.txt file</param>
        static void Main(string[] args)
        {
            List<String> unsorted = new List<String>();
            List<String> sorted;

            // Read from file
            string[] lines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {
                unsorted.Add(line);
            }

            // Logic:-
            // The Merge Sort algorithm in this example compares the first word of the given line. 
            // To sort by lastname first, the last name needs to appear in the beginning of the name. 
            // After sorting by last name, the line will be reversed again to sort by any given name.
 
            List<string> ReverseName = new List<string>();

            // Iterate twice, once to sort by last name and then to sort by given name.
            for (int count = 0; count < 2; count++)
            {
                ReverseName = new List<string>();

                foreach (var name in unsorted)
                {
                    // Call to reversing algorithm.
                    ReverseName.Add(Reverse.InputString(name));
                }

                sorted = MergeSort.MergeInputs(ReverseName);
                unsorted = sorted;
            }


            // Write onto file.
            System.IO.File.WriteAllLines("./sorted-names-list.txt", ReverseName.Select(t => t.TrimStart()).ToList().ToArray());

            // Wite to console.
            foreach (var x in ReverseName)
            {
                Console.WriteLine(x + " ");
            }

            // Wait for key
            Console.ReadKey();
        }
    }
    
}
