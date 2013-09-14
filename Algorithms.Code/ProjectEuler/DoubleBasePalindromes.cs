using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
    /// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
    /// (Please note that the palindromic number, in either base, may not include leading zeros.)
    /// </summary>
    public class DoubleBasePalindromes
    {
        public int Solve(int max)
        {
            var sum = 0;
            for (int i = 1; i < max; i++)
            {
                var d = i.ToString(CultureInfo.InvariantCulture);
                var dr = new string(d.Reverse().ToArray());
                if (d == dr)
                {
                    var b = Convert.ToString(i, 2);
                    var br = new string(b.Reverse().ToArray());
                    if (b == br)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}
