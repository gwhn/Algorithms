using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Searching
{
    public static class SearchSortedArrayForAIEqualsI
    {
        public static int IndexOf(int[] a)
        {
            var n = a.Length;
            var l = 0;
            var h = n - 1;
            while (l <= h)
            {
                var m = (l + h)/2;
                if (a[m] - m == 0)
                {
                    return m;
                }
                if (a[m] - m < 0)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
            return -1;
        }
    }
}
