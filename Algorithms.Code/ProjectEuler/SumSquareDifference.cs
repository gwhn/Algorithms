using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    ///     1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    ///     (1 + 2 + ... + 10)^2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers 
    /// and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural 
    /// numbers and the square of the sum.
    /// </summary>
    public class SumSquareDifference
    {
        public int Calculate(int n)
        {
            var ssq = 0.0D;
            for (int i = 1; i <= n; i++)
            {
                ssq += Math.Pow(i, 2);
            }
            var s = 0.0D;
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            var sqs = Math.Pow(s, 2);
            return (int) (sqs - ssq);
        }
    }
}
