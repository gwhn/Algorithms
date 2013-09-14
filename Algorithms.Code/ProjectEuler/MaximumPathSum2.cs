using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, 
    /// the maximum total from top to bottom is 23.
    ///    3
    ///   7 4
    ///  2 4 6
    /// 8 5 9 3
    /// That is, 3 + 7 + 4 + 9 = 23.
    /// Find the maximum total from top to bottom in triangle.txt (right click and 'Save Link/Target As...'), 
    /// a 15K text file containing a triangle with one-hundred rows.
    /// NOTE: This is a much more difficult version of Problem 18. 
    /// It is not possible to try every route to solve this problem, as there are 299 altogether! 
    /// If you could check one trillion (1012) routes every second it would take over twenty billion years to check them all. 
    /// There is an efficient algorithm to solve it. ;o)
    /// </summary>
    public class MaximumPathSum2
    {
        public int Solve(int[][] triangle)
        {
            var n = triangle.Length - 1;
            for (int i = n; i > 0; i--)
            {
                var m = triangle[i].Length - 1;
                for (int j = 0; j < m; j++)
                {
                    triangle[i - 1][j] = Math.Max(triangle[i][j] + triangle[i - 1][j],
                                                  triangle[i][j + 1] + triangle[i - 1][j]);
                }
            }
            return triangle[0][0];
        }
    }
}
