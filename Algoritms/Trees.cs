using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class Trees 
    {
        public static int[] array;

        /// <summary>
        /// Construct binary search tree list from sorted linked 
        /// </summary>
        /// <returns>root</returns>
        public static Node MakeBinaryTreeOfSortedArray()
        {
            int[] array = { 5, 7, 9, 11, 12, 18, 20 };

            if (array == null)
                return null;

            int left = 0;
            int right = array.Length - 1;            

            Node root = GetNode(array, left, right);
            return root;
        }

        /// <summary>
        /// Construct sorted linked list from binary search tree
        /// </summary>
        /// <returns>root</returns>
        public static void MakeSortedArrayOfBinaryTree()
        {
            var list = new List<int>();
            Track(GetSampleNode(), list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void MakeSortedArrayOfBinaryTree1()
        {
            var list = new List<int>();
            Track1(GetSampleNode(), list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Method to get node 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left">index of array</param>
        /// <param name="right">index of array</param>
        /// <returns></returns>
        public static Node GetNode(int[] array, int left, int right)
        {
            if (array == null)
                return null;

            int mid;
            Node node = null;
            if (left <= right)
            {
                mid = (left + right) / 2;
                node = new Node(array[mid]);
                node.Left = GetNode(array, left, mid-1);
                node.Right = GetNode(array,mid+1,right);
            }
            return node;
        }

        /// <summary>
        /// Track into tree
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left">index of array</param>
        /// <param name="right">index of array</param>
        /// <returns></returns>
        public static void Track(Node node, List<int> list)
        {
            if (node.Left != null)
                Track(node.Left, list);
            list.Add(node.Value);

            if (node.Right != null)
                Track(node.Right, list);
        }

        public static void Track1(Node node, List<int> list)
        {
            if (node == null)
                return;
            
            Track1(node.Left, list);
            list.Add(node.Value);
            Track1(node.Right, list);
        }

        private static Node GetSampleNode()
        {
            Node root;

            int[] array = new int[] { 5, 7, 9, 11, 12, 18, 20 };

            root = new Node(11);
            root.Left = new Node(7);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(9);
            root.Right = new Node(18);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(20);

            return root;
        }

    }
}
