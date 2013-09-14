using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
    /// there are exactly 6 routes to the bottom right corner.
    /// How many such routes are there through a 20×20 grid?
    /// </summary>
    public class LatticePaths
    {
        public BigInteger Solve(int n, int k)
        {
            BigInteger sf = Factorial(n);
            BigInteger cf = Factorial(k);
            BigInteger scf = Factorial(n - k);
            return sf/(cf*scf);
        }

        private BigInteger Factorial(BigInteger n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
