using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public class test3
    {
        /*You have an array p of points on a Cartesian plane. 
        Find and return the minimum possible Euclidian distance between two points with different indices in p.

        Example

        For p = [[0, 11], [-7, 1], [-5, -3]], the output should be
        solution(p) = 4.472135955.

        Input/Output

        [execution time limit] 3 seconds (cs)

        [input] array.array.integer p

        Every inner array p[i] contains exactly 2 integers: the x and y coordinates of the ith point.

        Guaranteed constraints:
        2 ≤ p.length ≤ 2 · 104,
        p[i].length = 2,
        |p[i][j]| ≤ 107.

        [output] float

        The minimum possible distance between two points with different indices in p.

        Your answer will be considered correct if its absolute error doesn't exceed 10-5.

        [C#] Syntax Tips

        // Prints help message to the console
        // Returns a string
        string helloWorld(string name) {
            Console.Write("This prints to the console when you Run Tests");
            return "Hello, " + name;
        }
        */

        /* public static float solution(int[][] points)
        {
            var result = 0;
            float euclidian(int x1, int x2, int y1, int y2)
            {
                return (float)Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            }
            float euclidian(int[] coordenates)
            {
                return (float)Math.Sqrt(Math.Pow((coordenates[0] - coordenates[1]), 2) + Math.Pow((coordenates[2] - coordenates[3]), 2));
            }

            for (int i = 0; i < points.Length-1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(points[i][i]);
                }
                
            }
            return 0.1f;
        } */

    }
}