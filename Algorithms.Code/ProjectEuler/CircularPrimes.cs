using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The number, 197, is called a circular prime because all rotations of the digits: 
    /// 197, 971, and 719, are themselves prime.
    /// There are thirteen such primes below 100: 
    /// 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
    /// How many circular primes are there below one million?
    /// </summary>
    public class CircularPrimes
    {
        public int Solve(int max)
        {
            var count = 0;
            for (int i = 2; i < max; i++)
            {
                if (IsCircularPrime(i))
                {
                    count++;
                }
            }
            return count;
        }

        private static bool IsCircularPrime(int n)
        {
            if (!Primes.IsPrime(n))
            {
                return false;
            }
            var s1 = n.ToString(CultureInfo.InvariantCulture);
            var l = s1.Length;
            if (l == 1)
            {
                return true;
            }
            var s2 = s1 + s1;
            for (int i = 0; i < l - 1; i++)
            {
                var s3 = s2.Substring(i + 1, l);
                var v = Convert.ToInt32(s3);
                if (!Primes.IsPrime(v))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
