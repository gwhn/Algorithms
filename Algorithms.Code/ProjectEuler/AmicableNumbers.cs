using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
    /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and 
    /// each of a and b are called amicable numbers.
    /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
    /// therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
    /// Evaluate the sum of all the amicable numbers under 10000.
    /// </summary>
    public class AmicableNumbers
    {
        public int Solve(int n)
        {
            var total = 0;
            for (int i = 1; i < n; i++)
            {
                var a = Divisors(i);
                var suma = a.Sum();
                if (suma == i)
                {
                    continue;
                }
                var b = Divisors(suma);
                var sumb = b.Sum();
                if (sumb == i)
                {
                    total += suma;
                }
            }
            return total;
        }

        public static List<int> Divisors(int n)
        {
            var list = new List<int>();
            var m = Math.Sqrt(n);
            for (int i = 1; i <= m; i++)
            {
                if (n%i == 0)
                {
                    list.Add(i);
                    var v = n/i;
                    if (v != n)
                    {
                        list.Add(v);
                    }
                }
            }
            return list;
        }
    }
}
