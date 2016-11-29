using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class BinarySearchAlgoritm
    {
        public static int getIndexOfElementInArray(int[] array, int x)
        {
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
