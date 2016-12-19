using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class Search
    {
        /// <summary>
        /// This is Binary Searching Algoritm which searches element into sorted array
        /// </summary>
        public static void SearchingAnElementIntoSortedArray()
        {
            int[] a = { 2, 4, 5, 7, 9, 10, 11 };
            int x = 4;

            int index = getIndexOfElementInArray(a, x);

            Console.WriteLine(index);
        }

       /// <summary>
       /// Get index of element into sorted array
       /// </summary>
       /// <param name="array"></param>
       /// <param name="x">Searched element</param>
       /// <returns>-1 if x doesn't exist into the array</returns>
        public static int getIndexOfElementInArray(int[] array, int x)
        {
            if (array == null || array.Length == 0)
                return -1;

            int left = 0;
            int right = array.Count();
            int mid;

            if (array.Count() != 0 && array != null)
            {
                while (left <= right)
                {
                    mid = (right + left) / 2;
                    if (array[mid] == x)
                        return mid;
                    else
                    {
                        if (x < array[mid])
                            right = mid - 1;
                        else
                            left = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
