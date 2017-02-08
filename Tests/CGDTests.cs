using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritms;

namespace Tests
{
    [TestClass]
    public class CGDTests
    {
        [TestMethod]
        public void FindCGDForNullArray()
        {
            int cgd = 1;
            Assert.AreEqual(cgd, NumberTheory.FindCGDForArrayElements(null));
        }

        [TestMethod]
        public void FindCGDForArraySuccess()
        {
            int[] array = { 3, 9, 21 };
            int cgd = 3;
            Assert.AreEqual(cgd, NumberTheory.FindCGDForArrayElements(array));
        }

        [TestMethod]
        public void FindCGDForShortArraySuccess()
        {
            int[] array = { 5 };
            int cgd = 5;
            Assert.AreEqual(cgd, NumberTheory.FindCGDForArrayElements(array));
        }
    }
}
