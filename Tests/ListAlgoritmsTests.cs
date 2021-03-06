﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritms;

namespace Tests
{
    [TestClass]
    public class ListAlgoritmsTests
    {
        [TestMethod]
        public void FindLostElementSuccess()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 4, 5 };
            int c = 3;
            int lostEl = Lists.GetLostElement(a, b);
            Assert.AreEqual(c,lostEl);
        }

        [TestMethod]
        public void FindLostElementNullArrays1()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = null;
            int c = -1;
            int lostEl = Lists.GetLostElement(a, b);
            Assert.AreEqual(c, lostEl);
        }

        [TestMethod]
        public void FindLostElementNullArrays2()
        {
            int[] a = { 1 };
            int[] b = null;
            int c = 1;
            int lostEl = Lists.GetLostElement(a, b);
            Assert.AreEqual(c, lostEl);
        }

        [TestMethod]
        public void FindLostElementIncorrectArrays()
        {
            int[] a = { 1 };
            int[] b = { 1, 2, 3, 4, 5 };
            int c = -1;
            int lostEl = Lists.GetLostElement(a, b);
            Assert.AreEqual(c, lostEl);
        }

        [TestMethod]
        public void MergeTwoListToOneSuccess()
        {
            int[] a = { 1, 5, 7, 45, 890 };
            int[] b = { 2, 4, 5 };
            int[] c = { 1, 2, 4, 5, 5, 7, 45, 890 };
            int[] array = Lists.GetSortedList(a, b);
            Assert.IsTrue(AreArraysEqual(c,array));
        }

        [TestMethod]
        public void MergeTwoListToOneNullArrays()
        {
            int[] a = { 1, 5, 7, 45, 890 };
            int[] b = { };
            int[] c = { 1, 5, 7, 45, 890 };
            int[] array = Lists.GetSortedList(a, b);
            Assert.IsTrue(AreArraysEqual(c, array));
        }

        [TestMethod]
        public void MergeTwoListToOneNullArrays2()
        {
            int[] a = null;
            int[] b = { 1 };
            int[] c = { 1 };
            int[] array = Lists.GetSortedList(a, b);
            Assert.IsTrue(AreArraysEqual(c, array));
        }

        [TestMethod]
        public void MergeTwoListToOneNullArrays3()
        {
            int[] a = null;
            int[] b = null;
            int[] c = null;
            int[] array = Lists.GetSortedList(a, b);
            Assert.IsTrue(AreArraysEqual(c, array));
        }

        bool AreArraysEqual(int[] a, int[] b)
        {
            if (a == null && b == null)
                return true;
            if (a == null && b != null)
                return false;
            if (a != null && b == null)
                return false;
            if (a.Length != b.Length)
                return false;
            else
            {
                for(int i=0; i<a.Length; i++)
                {
                    if (a[i] != b[i])
                        return false;
                }
            }
            return true;
        }
    }
}
