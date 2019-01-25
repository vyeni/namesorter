using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace NameSorterTest
{
    /// <summary>
    /// Tests for CompareWordsClass
    /// </summary>
    [TestClass]
    public class CompareWordsTest
    {
        [TestMethod]
        public void IsLeftWordSmaller_ByLength_Test()
        {
            // Arrange
            var word1 = "aa";
            var word2 = "aaa";

            // Act and Assert
            Assert.IsTrue(CompareWords.IsLeftWordSmaller(word1, word2));

        }

        [TestMethod]
        public void IsLeftWordSmallerByCharacters_Test()
        {
            // Arrange
            var word1 = "Abba Test";
            var word2 = "Abba Zac";

            // Act and Assert
            Assert.IsTrue(CompareWords.IsLeftWordSmaller(word1, word2));

        }

        [TestMethod]
        public void IsLeftWordSmallerByCharacters2_Test()
        {
            // Arrange
            var word1 = "aaab";
            var word2 = "ab";
            Assert.IsTrue(CompareWords.IsLeftWordSmaller(word1, word2));

        }

        [TestMethod]
        public void IsLeftWordSmallerByCharacters_False_Test()
        {
            // Arrange
            var word1 = "aaab";
            var word2 = "ab";
            Assert.IsFalse(CompareWords.IsLeftWordSmaller(word2, word1));

        }

    }
}
