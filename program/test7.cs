using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test7
    {
        /*
        Find the most repeated character in a string
        */
        public static Tuple<char?, int> solution(string phrase)
        {
            var mostRepeated = new Tuple<char?, int>(null, 0);
            char[] characters = phrase.ToCharArray();
            object? count = 0;
            int max = 0;
            Hashtable list = new Hashtable();

            foreach (char item in characters)
            {
                if (list.ContainsKey(item))
                {
                    count = list[item];
                    list[item] = int.Parse(count.ToString()) + 1;
                }
                else list.Add(item, 1);

                if ((int.Parse(count.ToString()) + 1) > max)
                {
                    max = int.Parse(count.ToString()) + 1;
                    mostRepeated = new Tuple<char?, int>(item, max);
                }
            }

            return mostRepeated;
        }
    }
}