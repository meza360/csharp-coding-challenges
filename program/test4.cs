using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test4
    {
        public static int solution(string[] ops)
        {
            List<int> record = new List<int>();
            int result = 0;
            int current = 0;
            try
            {
                for (int i = 0; i < ops.Length; i++)
                {
                    if (ops[i] == "C") { record.RemoveAt(i - 1); continue; }
                    if (ops[i] == "D") { record.Add(record.Last() * 2); continue; }
                    if (ops[i] == "+") { record.Add(record.Last() + record.ElementAt(record.Count - 2)); continue; }
                    else
                    {
                        current = int.Parse(ops[i]);
                        record.Add(current);
                    }
                }

                foreach (int score in record)
                {
                    result += score;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in:" + e.Message);
                Console.WriteLine("Error from:" + e.StackTrace);
            }
            return result;
        }

        /*
            You are keeping the score of a baseball game.
            At the beginning of the game, you start with an empty record. You ae giben a list of strings ops
            where ops[i] is the ith operation you must apply

            + record a new score thatis the sum of the previous to scores
            D record a new score that is double the previous score
            C invalidate the previous score

            input: ops = ["5", "2", "C", "D", "+"]
            output: 30

            input: ops = ["5", "-2", "4", "C", "D", "9", "+", "+"]
            output: 27

            input: ops = ["1"]
            output: 1

            
        */
    }
}