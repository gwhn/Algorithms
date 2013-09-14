using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
    /// 1634 = 1^4 + 6^4 + 3^4 + 4^4
    /// 8208 = 8^4 + 2^4 + 0^4 + 8^4
    /// 9474 = 9^4 + 4^4 + 7^4 + 4^4
    /// As 1 = 1^4 is not a sum it is not included.
    /// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
    /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
    /// </summary>
    public class DigitFifthPowers
    {
        public long Solve(int p)
        {
            long n = (long) ((p + 1)*Math.Pow(9, p));
            long t = 0;
            for (long i = 2; i <= n; i++)
            {
                long s = 0;
                long d = i;
                do
                {
                    s += (long) Math.Pow(d % 10, p);
                    d /= 10;
                } while (d > 0);
                if (s==i)
                {
                    t += s;                    
                }
            }
            return t;
        }
    }
}
