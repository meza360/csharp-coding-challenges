using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test8
    {
        /*
        Write a C# program to find the longest word in a string.
        */
        public static string? solution(string phrase)
        {
            string[] words = phrase.Split(" ");
            int maxLength = 0;
            string? maxWord = null;

            foreach (var word in words)
            {
                if (word.Length > maxLength) maxWord = word;
            }
            return maxWord;
        }
    }
}