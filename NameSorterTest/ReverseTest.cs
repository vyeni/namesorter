using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace NameSorterTest
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void ReverseInputString_Test()
        {
            // Arrange
            var str = "quick brown fox jumps";

            // Act

            // Words will reverse
            var response1 = Reverse.InputString(str);

            // Words will not reverse
            var response2 = Reverse.InputString(response1);
         
            // Assert
            Assert.AreEqual(response1.Trim(), "jumps fox brown quick");
            Assert.AreEqual(response2.Trim(), "quick brown fox jumps");
        }
    }
}
