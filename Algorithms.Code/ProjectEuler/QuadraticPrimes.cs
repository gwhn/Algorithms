using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Euler discovered the remarkable quadratic formula:
    ///     n² + n + 41
    /// It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39. 
    /// However, when n = 40, 402 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, 
    /// and certainly when n = 41, 41² + 41 + 41 is clearly divisible by 41.
    /// The incredible formula  n² − 79n + 1601 was discovered, 
    /// which produces 80 primes for the consecutive values n = 0 to 79. 
    /// The product of the coefficients, −79 and 1601, is −126479.
    /// Considering quadratics of the form:
    ///     n² + an + b, where |a| &lt; 1000 and |b| &lt; 1000
    /// where |n| is the modulus/absolute value of n
    /// e.g. |11| = 11 and |−4| = 4
    /// Find the product of the coefficients, a and b, for the quadratic expression that 
    /// produces the maximum number of primes for consecutive values of n, starting with n = 0.
    /// </summary>
    public class QuadraticPrimes
    {
        public int Solve(int mina, int maxa, int minb, int maxb)
        {
            var ma = 0;
            var mb = 0;
            var mn = 0;
            for (int a = mina + 1; a < maxa; a++)
            {
                for (int b = minb + 1; b < maxb; b++)
                {
                    var n = 0;
                    while (true)
                    {
                        var p = (n*n) + (a*n) + b;
                        if (!Primes.IsPrime(p))
                        {
                            break;
                        }
                        n++;
                    }
                    if (n > mn)
                    {
                        mn = n;
                        ma = a;
                        mb = b;
                    }
                }
            }
            return ma*mb;
        }
    }
}
