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
    }
}
