using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, 
    /// there are exactly three solutions for p = 120.
    ///     {20,48,52}, {24,45,51}, {30,40,50}
    /// For which value of p ≤ 1000, is the number of solutions maximised?
    /// </summary>
    public class IntegerRightTriangles
    {
        public int Solve(int p)
        {
            // a^2 + b^2 = c^2
            // a + b + c = p
            // => a^2 + b^2 = (p - a - b)^2
            // => b = p(p - 2a) / 2(p - a)
            // => if p(p - 2a) % 2(p - a) == 0 then right triangle
            var maxs = 0;
            var maxp = 3;
            for (int i = 3; i <= p; i++)
            {
                var s = 0;
                for (int a = 2; a < i; a++)
                {
                    var r = (i*(i - (2 * a)))%(2*(i - a));
                    if (r == 0)
                    {
                        s++;
                    }
                }
                if (s > maxs)
                {
                    maxs = s;
                    maxp = i;
                }
            }
            return maxp;
        }
    }
}
