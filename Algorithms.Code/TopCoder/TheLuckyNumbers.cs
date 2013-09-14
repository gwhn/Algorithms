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
    /// You are given ints a and b. 
    /// Return the number of lucky numbers between a and b, inclusive.
    /// 
    /// Constraints
    /// a will be between 1 and 1,000,000,000, inclusive.
    /// b will be between a and 1,000,000,000, inclusive.
    /// </summary>
    public class TheLuckyNumbers
    {
        public int Count(int a, int b)
        {
            var list = new List<int>();
            for (int i = a; i <= b; i++)
            {
                var value = i.ToString(CultureInfo.InvariantCulture);
                if (value.All(x => x == '4' || x == '7'))
                {
                    list.Add(i);
                }
            }
            return list.Count;
        }
    }
}
