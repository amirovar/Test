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
