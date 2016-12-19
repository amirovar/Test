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

        public void BeforeSuccessTest()
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

        public void BeforeFailedTest()
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

        [TestMethod]
        public void SuccessMakeBinaryTreeOfSortedArrayTest()
        {
            BeforeSuccessTest();
            int left = 0;
            int right = array.Length - 1;

            Node actualRoot = Trees.GetNode(array,left,right);

            Assert.IsTrue(root.Compare(root,actualRoot));
        }

        [TestMethod]
        public void FailedMakeBinaryTreeOfSortedArrayTest()
        {
            BeforeFailedTest();
            int left = 0;
            int right = array.Length - 1;

            Node actualRoot = Trees.GetNode(array, left, right);

            Assert.IsFalse(root.Compare(root, actualRoot));
        }

    }
}
