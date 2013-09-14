using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
    ///     1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
    /// It is possible to make £2 in the following way:
    ///     1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
    /// How many different ways can £2 be made using any number of coins?
    /// </summary>
    public class CoinSums
    {
        public int Solve(int target, int[] coins)
        {
            int n = coins.Length;
            var matrix = new int[target+1,n];
            for (int y = 0; y < target+1; y++)
            {
                matrix[y, 0] = 1;
            }
            for (int y = 0; y < target+1; y++)
            {
                for (int x = 1; x < n; x++)
                {
                    if (y >= coins[x])
                    {
                        matrix[y, x] += matrix[y, x - 1];
                        matrix[y, x] += matrix[y - coins[x], x];
                    }
                    else
                    {
                        matrix[y, x] = matrix[y, x - 1];
                    }
                }
            }
            return matrix[target, n - 1];
        }
    }
}
