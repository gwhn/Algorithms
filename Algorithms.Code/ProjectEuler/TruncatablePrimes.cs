using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The number 3797 has an interesting property. Being prime itself,
    /// it is possible to continuously remove digits from left to right, 
    /// and remain prime at each stage: 3797, 797, 97, and 7. 
    /// Similarly we can work from right to left: 3797, 379, 37, and 3.
    /// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
    /// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
    /// </summary>
    public class TruncatablePrimes
    {
        public long Solve()
        {
            long i = 23;
            int count = 0;
            long sum = 0;
            do
            {
                if (Primes.IsPrime(i))
                {
                    string s = i.ToString(CultureInfo.InvariantCulture);
                    int n = s.Length;
                    bool ok = true;
                    for (int j = 1, k = n - 1; j < n && k > 0; j++, k--)
                    {
                        long left = Convert.ToInt32(s.Substring(j));
                        long right = Convert.ToInt32(s.Substring(0, k));
                        if (!Primes.IsPrime(left) || !Primes.IsPrime(right))
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        count++;
                        sum += i;
                    }
                }

                i++;
            } while (count != 11);
            return sum;
        }
    }
}
