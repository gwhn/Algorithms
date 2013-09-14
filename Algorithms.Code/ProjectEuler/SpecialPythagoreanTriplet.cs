using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a &lt; b &lt; c, for which,
    ///     a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class SpecialPythagoreanTriplet
    {
        public int Product(int n)
        {
            for (int a = 1; a < n; a++)
            {
                for (int b = 2; b <= n; b++)
                {
                    var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    var s = a + b + c;
                    if (s >= n - 1e-9 && s <= n + 1e-9)
                    {
                        return (int) (a*b*c);
                    }                    
                }
            }
            return 0;
        }
    }
}
