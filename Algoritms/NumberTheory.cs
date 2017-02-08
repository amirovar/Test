using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public static class NumberTheory
    {
        /// <summary>
        /// Please find the most common divizor for an array of integer
        /// </summary>
        public static void FindTheMostCommonDivizor()
        {
            int[] a = { 24, 42, 8 };

            int cgd = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                cgd = GetCGD(cgd, a[i]);
            }

            Console.WriteLine(cgd);
        }

        public static int FindCGDForArrayElements(int[] a)
        {
            if (a == null)
                return 1;

            int cgd = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                cgd = GetCGD(cgd, a[i]);
            }

            return cgd;
        }

        /// <summary>
        /// Get CGD of numbers
        /// Euclid (recursive) algorithm
        /// </summary>
        /// <param name="a">first integer</param>
        /// <param name="b">second integer</param>
        /// <returns>CGD of numbers</returns>
        public static int GetCGD(int a, int b)
        {
            while (a != b)
            {
                if (a == 0 || b == 0)
                    return 1;
                if (a >= b)
                {
                    if (a % b == 0)
                        return b;
                    else
                        a = a - b;
                }
                else
                {
                    if (b % a == 0)
                        return a;
                    else
                        b = b - a;
                }
            }

            return a;
        }
    }
}
