using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// Find the sum of the digits in the number 100!
    /// </summary>
    public class FactorialDigitSum
    {
        public int Solve(int n)
        {
            var f = Factorial(n);
            BigInteger sum = 0;
            while (f > 0)
            {
                sum += f%10;
                f /= 10;
            }
            return (int) sum;
        }

        private BigInteger Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
