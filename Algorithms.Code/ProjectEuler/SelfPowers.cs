using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
    /// Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
    /// </summary>
    public class SelfPowers
    {
        public string Solve(int n)
        {
            BigInteger sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += BigInteger.Pow(i, i);
            }
            var s = sum.ToString();
            var l = s.Length;
            return s.Substring(l - 10, 10);
        }
    }
}
