using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    public class NthPrime
    {
        public long Find(int n)
        {
            var result = 2;
            var i = 0;
            do
            {
                if (Primes.IsPrime(result))
                {
                    i++;
                }
                result++;
            } while (i < n);
            return result - 1;
        }
    }
}
