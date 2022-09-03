using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test2
    {
    /*
    Given a string sequence 
    consisting of the characters '(', ')', '[', ']', '{', and '}'. 
    Your task is to determine whether or not the sequence is a valid bracket sequence.

    The Valid bracket sequence is defined in the following way:

    An empty bracket sequence is a valid bracket sequence.
    If S is a valid bracket sequence then (S), [S] and {S} are also valid.
    If A and B are valid bracket sequences then AB is also valid.
    Example

    For sequence = "()", the output should be solution(sequence) = true;
    For sequence = "()[]{}", the output should be solution(sequence) = true;
    For sequence = "(]", the output should be solution(sequence) = false;
    For sequence = "([)]", the output should be solution(sequence) = false;
    For sequence = "{[]}", the output should be solution(sequence) = true.
    Input/Output

    [execution time limit] 3 seconds (cs)

    [input] string sequence

    A bracket sequence, consisting of the characters (, ), [, ], {, and }.

    Guaranteed constraints:
    0 ≤ sequence.length ≤ 106.

    [output] boolean

    true if sequence is a valid bracket sequence and false otherwise.

    [C#] Syntax Tips

    // Prints help message to the console
    // Returns a string
    string helloWorld(string name) {
        Console.Write("This prints to the console when you Run Tests");
        return "Hello, " + name;
    }
    */

        public static bool solution(string sequence)
        {
            /*Getting index of any symgol, if exists*/
            int openingPa = sequence.IndexOf('(');
            int closingPa = sequence.LastIndexOf(')');

            int openingBr = sequence.IndexOf('[');
            int closingBr = sequence.LastIndexOf(']');

            int openingCr = sequence.IndexOf('{');
            int closingCr = sequence.LastIndexOf('}');
            

            int lenPa = 0; lenPa = (closingPa - openingPa) - 1; //parenthesis checker
            int lenCr = 0; lenCr = (closingCr - openingCr) - 1; //curly checker
            int lenBr = 0; lenBr = (closingBr - openingBr) - 1; //bracket checker

            string? current; //exchange string
            bool result = true; //result variable to be return

            if(openingPa == -1 && closingPa != -1 || openingPa != -1 && closingPa == -1) result = false;  
            if(openingBr == -1 && closingBr != -1 || openingBr != -1 && closingBr == -1) result = false;  
            if(openingCr == -1 && closingCr != -1 || openingCr != -1 && closingCr == -1) result = false;  
            //Console.WriteLine(result);
            if (!result) return false;

            while (result)
            {
                //Parenthesis checker
                switch (openingPa)
                {
                    case 0:
                        current = sequence.Substring(openingPa + 1,lenPa);
                            return solution(current);

                    default:
                    break;
                }

                //Brackets checker
                switch (openingBr)
                {
                    case 0:
                        current = sequence.Substring(openingBr + 1,lenBr);
                            return solution(current);

                    default:
                    break;
                }
                //Braces checker
                switch (openingCr)
                {
                    case 0:
                        current = sequence.Substring(openingCr + 1,lenCr);
                            return solution(current);

                    default:
                    break;
                }
                break;
            }            
            return result;
        }
    }
}