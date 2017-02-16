using Algoritms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class TreesAlgoritmsTests
    {
        public Node root;
        public int[] array;
        public List<int> list;

        public void BeforeSuccessMakeTreeTest()
        {
            array = new int[] { 5, 7, 9, 11, 12, 18, 20 };
            root = new Node(11);
            root.Left = new Node(7);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(9);
            root.Right = new Node(18);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(20);
        }

        public void BeforeSuccessMakeArrayTest()
        {
            list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Add(11);
            list.Add(12);
            list.Add(18);
            list.Add(20);

            root = new Node(11);
            root.Left = new Node(7);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(9);
            root.Right = new Node(18);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(20);
        }

        public void BeforeFailedMakeTreeTest()
        {
            array = new int[] { 5, 7, 9, 12, 18, 20 };
            root = new Node(11);
            root.Left = new Node(7);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(9);
            root.Right = new Node(18);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(20);
        }

        public void BeforeFailedMakeArrayTest()
        {
            list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Add(12);
            list.Add(18);
            list.Add(20);

            root = new Node(11);
            root.Left = new Node(7);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(9);
            root.Right = new Node(18);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(20);
        }

        [TestMethod]
        public void SuccessMakeBinaryTreeOfSortedArrayTest()
        {
            BeforeSuccessMakeTreeTest();
            int left = 0;
            int right = array.Length - 1;

            Node actualRoot = Trees.GetNode(array,left,right);

            Assert.IsTrue(root.Compare(root,actualRoot));
        }

        [TestMethod]
        public void SuccessMakeSortedArrayOfBinaryTreeTest()
        {
            BeforeSuccessMakeArrayTest();

            var actualList = new List<int>();

            Trees.Track(root, actualList);

            Assert.IsTrue(list.Count == actualList.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list.ElementAt(i), actualList.ElementAt(i));
            }
        }

        [TestMethod]
        public void FailedMakeSortedArrayOfBinaryTreeTest()
        {
            BeforeFailedMakeArrayTest();

            var actualList = new List<int>();

            Trees.Track(root, actualList);

            Assert.IsFalse(list.Count == actualList.Count);
        }

        [TestMethod]
        public void FailedMakeBinaryTreeOfSortedArrayTest()
        {
            BeforeFailedMakeTreeTest();
            int left = 0;
            int right = array.Length - 1;

            Node actualRoot = Trees.GetNode(array, left, right);

            Assert.IsFalse(root.Compare(root, actualRoot));
        }

    }
}
