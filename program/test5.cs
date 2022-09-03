using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test5
    {
        //sort an array of numbers without using sort method descending
        public static int[] solution(int[] values)
        {
            int aux = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if(values[i] > values[j])
                    {
                        aux = values[i];
                        values[i] = values[j];
                        values[j] = aux;
                    }
                    aux = 0;
                }
            }
            return values;
        }
    }
}