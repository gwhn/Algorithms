using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    public class PowerDigitSum
    {
        public int Sum(int n, int p)
        {
            var value = BigInteger.Pow(n, p);
            var result = 0;
            while (value > 0)
            {
                result += (int) (value%10);
                value /= 10;
            }
            return result;
        }
    }
}
