namespace program
{ 
    public static class test1
    {
/*
Given two strings a and b, both consisting only of lowercase English letters, 
your task is to calculate how many strings equal to a can be constructed using only letters from the string b? 
Each letter can be used only once and in one string only.

Example

For a = "abc" and b = "abccba", the output should be solution(a, b) = 2.

We can construct 2 strings a = "abc" using only letters from the string b.

For a = "ab" and b = "abcbcb", the output should be solution(a, b) = 1.

Input/Output

[execution time limit] 3 seconds (cs)

[input] string a

String to construct, containing only lowercase English letters.

Guaranteed constraints:
1 ≤ a.length ≤ 105.

[input] string b

String containing needed letters, containing only lowercase English letters.

Guaranteed constraints:
1 ≤ b.length ≤ 105.

[output] integer

The number of strings a that can be constructed from the string b.

[C#] Syntax Tips

// Prints help message to the console
// Returns a string
string helloWorld(string name) {
    Console.Write("This prints to the console when you Run Tests");
    return "Hello, " + name;
}
*/
        public static int solution(string a, string b) {

            int stringCounts = 0; //store the number of times b string can be made equal to a
            char[]? auxiliar = b.ToCharArray(); //split the b string into a character array
            string? compared = String.Empty; //initialize the object to compare strings
            int stopIndex = (b.Length - a.Length); //the counting on each for loop should not exceed a-3 lenght

            //Normal sequence counting
            for (int i = 0; i <= stopIndex; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    compared+= auxiliar[j+i]; //Creates a new string with the char in j+i index 
                }
                if(a.Equals(compared)) stringCounts++;
                compared = String.Empty;
            }
            //Reverse sequence counting
            Array.Reverse(auxiliar);
            for (int i = 0; i <= (b.Length - a.Length); i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    compared+= auxiliar[j+i];
                }
                if(a.Equals(compared)) stringCounts++;
                compared = String.Empty;
            }    
            return stringCounts; //returns how many times a == b
        }
    }
}