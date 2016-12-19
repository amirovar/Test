using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritms;

namespace Tests
{
    [TestClass]
    public class BinarySearchAlgoritmTests
    {
        [TestMethod]
        public void FailSearching()
        {
            int[] a = { 1, 5, 7, 45, 890 };
            int x = 4;
            Assert.AreEqual(-1, Search.getIndexOfElementInArray(a, x));
        }

        [TestMethod]
        public void SuccessSearching()
        {
            int[] a = { 1, 5, 7, 45, 890 };
            int x = 45;
            Assert.AreEqual(3, Search.getIndexOfElementInArray(a, x));
        }
    }
}
