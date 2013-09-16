using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Searching
{
    public static class SquareRoot
    {
        public static double Calculate(double n, double p)
        {
            double low = 0.0D;
            double high = Math.Max(1, n);
            double mid;
            while (low + p < high)
            {
                mid = (low + high)/2.0D;
                if (mid * mid < n)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}
