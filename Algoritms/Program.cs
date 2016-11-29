using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 7, 9, 10, 11 };
            int x = 4;

            int index = BinarySearchAlgoritm.getIndexOfElementInArray(a, x);

            Console.WriteLine(index);       
        }
    }
}
