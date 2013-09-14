using System;
using System.Globalization;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class LargestPalindromeProduct
    {
        public int Max(int n)
        {
            var max = 0;
            var start = Convert.ToInt32("1".PadRight(n, '0'));
            var end = Convert.ToInt32("1".PadRight(n+1, '0')) - 1;
            for (int i = end; i >= start; i--)
            {
                for (int j = end; j >= start; j--)
                {
                    var product = i*j;
                    var s = product.ToString(CultureInfo.InvariantCulture);
                    var l = s.Length;
                    var ok = true;
                    for (int k = 0; k <= l/2; k++)
                    {
                        if (s[k] != s[l-1-k])
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        max = Math.Max(max, product);
                    }
                }
            }
            return max;
        }
    }
}
