using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class Lists
    {
        /// <summary>
        /// This is algoritm to merge two sorted lists to one sorted
        /// </summary>
        public static void MergeTwoSortedListToOne()
        {
            int[] a = { 2, 4, 5, 7, 9, 10, 11 };
            int[] b = { 1, 3, 6, 8 };

            int[] c = GetSortedList(a, b);

            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Given array a from 1 till n (1,2,3,4,5..n)
        /// given array b. b derived from a without one element
        /// find the lost element
        /// </summary>
        public static void FindLostElement()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = { 1, 2, 3, 4, 5, 7, 8, 9 };

            int c = GetLostElement(a, b);

            Console.WriteLine(c);
        }

        /// <summary>
        /// Get element from a which has lost in b
        /// </summary>
        /// <param name="a">first sorted array</param>
        /// <param name="b">second sorted array</param>
        /// <returns></returns>
        public static int GetLostElement(int[] a, int[] b)
        {
            if (a == null)
                return -1;

            if (b == null && a.Length == 1)
                return a[0];
            else
            {
                if (b == null && a.Length > 1)
                    return -1;
            }

            if ((a.Length - b.Length) > 1 || (a.Length - b.Length) < 1)
            {
                return -1;
            }
                 
            int sum_a = 0;
            int sum_b = 0;

            foreach (int i in a)
            {
                sum_a += i;
            }

            foreach (int j in b)
            {
                sum_b += j;
            }

            return sum_a - sum_b;
        }

        /// <summary>
        /// Get sorted array from two sorted lists
        /// </summary>
        /// <param name="a">first sorted array</param>
        /// <param name="b">second sorted array</param>
        /// <returns></returns>
        public static int[] GetSortedList (int[] a, int[] b)
        {
            if (a == null || a.Length == 0)
                return b;
            else
                if (b == null || b.Length == 0)
                return a;

            int[] array = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] == b[j])
                {
                    array[k] = a[i];
                    array[k + 1] = b[j];
                    i++;
                    j++;
                    k+=2;
                }
                else
                {
                    if (a[i] < b[j])
                    {
                        array[k] = a[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        array[k] = b[j];
                        j++;
                        k++;
                    }
                }
            }

            if(i != a.Length - 1)
            {
                while (i < a.Length)
                {
                    array[k] = a[i];
                    i++;
                    k++;
                }
            }
            else
            {
                if (j != b.Length - 1)
                {
                    while (j < b.Length)
                    {
                        array[k] = b[j];
                        j++;
                        k++;
                    }
                }
            }

            return array;
        }

    }
}
