using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// John thinks 4 and 7 are lucky digits, and all other digits are not lucky. 
    /// A lucky number is a number that contains only lucky digits in decimal notation.
    /// You are given an int n. 
    /// Return the largest lucky number that is less than or equal to n.
    /// 
    /// Constraints
    /// n will be between 4 and 1,000,000, inclusive.
    /// </summary>
    public class TheLargestLuckyNumber
    {
        public int Find(int n)
        {
            for (int i = n; i > 3; i--)
            {
                var value = i.ToString(CultureInfo.InvariantCulture);
                var ok = value.All(x => x == '4' || x == '7');
                if (ok)
                {
                    return i;
                }
            }
            return 4;
        }
    }
}
