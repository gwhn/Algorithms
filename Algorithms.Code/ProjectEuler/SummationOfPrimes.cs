using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class SummationOfPrimes
    {
        public long Sum(int n)
        {
            long sum = 2L;
            for (int i = 3; i < n; i++)
            {
                if (Primes.IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
