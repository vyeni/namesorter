using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace NameSorterTest
{
    [TestClass]
    public class MergeSortTest
    {

        [TestMethod]
        public void MergeInputsSuccess_Test()
        {
            // Arrange
            List<String> unsorted = new List<String>();
            unsorted.Add("Janet Parsons");
            unsorted.Add("Vaughn Lewis");
            unsorted.Add("Adonis Julius Archer");
            unsorted.Add("Shelby Nathan Yoder");
            unsorted.Add("Marin Alvarez");
            unsorted.Add("London Lindsey");

            // Act
            var response = MergeSort.MergeInputs(unsorted);

            // Assert
            Assert.AreEqual(response[0].ToString(), "Adonis Julius Archer");
        }
    }
}
