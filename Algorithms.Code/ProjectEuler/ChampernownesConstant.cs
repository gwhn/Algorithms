using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// An irrational decimal fraction is created by concatenating the positive integers:
    ///     0.123456789101112131415161718192021...
    /// It can be seen that the 12th digit of the fractional part is 1.
    /// If dn represents the nth digit of the fractional part, find the value of the following expression.
    /// d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
    /// </summary>
    public class ChampernownesConstant
    {
        public int Solve(int p)
        {
            var max = (int) Math.Pow(10, p);
            var sb = new StringBuilder(max);
            var n = 1;
            do
            {
                sb.Append(n);
                n++;
            } while (sb.Length <= max);
            var x = 1;
            for (int i = 0; i <= p; i++)
            {
                x *= int.Parse(sb[(int) Math.Pow(10, i) - 1].ToString(CultureInfo.InvariantCulture));
            }
            return x;
        }
    }
}
