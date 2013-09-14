using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
    /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
    /// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
    /// </summary>
    public class DigitFactorials
    {
        public int Solve()
        {
            var factorials = new Dictionary<int, int>(10) {{0, 1}, {1, 1}, {2, 2}};
            for (int i = 3; i < 10; i++)
            {
                var f = i;
                for (int j = i - 1; j > 1; j--)
                {
                    f *= j;
                }
                factorials.Add(i, f);
            }
            var total = 0;
            for (int i = 3; i < 1000000; i++)
            {
                var sum = 0;
                var d = i;
                do
                {
                    sum += factorials[d%10];
                    d /= 10;
                } while (d > 0);
                if (sum == i)
                {
                    total += sum;
                }
            }
            return total;
        }
    }
}
