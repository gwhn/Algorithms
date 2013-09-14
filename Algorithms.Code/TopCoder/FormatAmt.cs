using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// In documents, it is frequently necessary to write monetary amounts in a standard format. 
    /// We have decided to format amounts as follows:
    /// the amount must start with '$'
    /// the amount should have a leading '0' if and only if it is less then 1 dollar.
    /// the amount must end with a decimal point and exactly 2 following digits.
    /// the digits to the left of the decimal point must be separated into groups of three by commas 
    /// (a group of one or two digits may appear on the left).
    /// Create a class FormatAmt that contains a method amount that takes two int's, dollars and cents, 
    /// as inputs and returns the properly formatted String.
    /// 
    /// Notes
    /// One dollar is equal to 100 cents.
    /// 
    /// Constraints
    /// dollars will be between 0 and 2,000,000,000 inclusive
    /// cents will be between 0 and 99 inclusive
    /// </summary>
    public class FormatAmt
    {
        public String Amount(int dollars, int cents)
        {
            var d = dollars.ToString(CultureInfo.InvariantCulture);
            var n = d.Length;
            for (int i = n - 3; i > 0; i -= 3)
            {
                d = d.Substring(0, i) + "," + d.Substring(i);
            }
            var c = cents.ToString(CultureInfo.InvariantCulture);
            c = c.PadLeft(2, '0');
            return string.Format("${0}.{1}", d, c);
        }
    }
}
