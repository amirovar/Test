using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Program
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


        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 7, 9, 10, 11 };
            int x = 4;

            int index = getIndexOfElementInArray(a, x);

            Console.WriteLine(index);       
        }
    }
}
