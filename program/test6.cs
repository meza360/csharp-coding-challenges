using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test6
    {
        /*
        The goal is to rotate Array A, K  times
        Each element of the array will be shifted to the right K times.
        */
        public static int[] solution(int[] a, int k)
        {
            var aux = 0;
            for (int i = 1; i <= k; i++)
            {
                aux = a[a.Length - 1];
                for (int j = a.Length-1; j >= 1; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = aux;
            }
            return a;
        }
    }
}