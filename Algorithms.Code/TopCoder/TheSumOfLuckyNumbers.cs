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
    /// Some numbers can be represented as a sum of only lucky numbers. 
    /// Given an int n, return a int[] whose elements sum to exactly n. 
    /// Each element of the int[] must be a lucky number. 
    /// If there are multiple solutions, 
    /// only consider those that contain the minimum possible number of elements, 
    /// and return the one among those that comes earliest lexicographically. 
    /// A int[] a1 comes before a int[] a2 lexicographically if a1 contains a smaller number 
    /// at the first position where they differ. 
    /// If n cannot be represented as a sum of lucky numbers, return an empty int[] instead.
    /// 
    /// Constraints
    /// n will be between 1 and 1,000,000, inclusive.
    /// </summary>
    public class TheSumOfLuckyNumbers
    {
        public int[] Sum(int n)
        {
            var remainder = n;
            var list = new List<int>();
            Factorise(4, n, ref list);
            for (int i = 4; i <= n; i++)
            {
                var value = i.ToString(CultureInfo.InvariantCulture);
                if (value.All(x => x == '4' || x == '7'))
                {
                    var factor = remainder/i;
                    var modulo = remainder%i;
                    if (modulo == 0)
                    {
                        for (int j = 0; j < factor; j++)
                        {
                            list.Add(factor);
                        }
                    }
                    else if (remainder / i > 0)
                    {
                        
                    }
                }
            }
            throw new NotImplementedException();
        }

        private void Factorise(int from, int to, ref List<int> list)
        {
            for (int i = from; i <= to; i++)
            {
                var value = i.ToString(CultureInfo.InvariantCulture);
                if (value.All(x => x == '4' || x == '7'))
                {
                    var factor = to/i;
                    var modulo = to%i;

                }
            }
        }
    }
}
