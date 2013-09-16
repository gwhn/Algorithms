using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Searching
{
    public static class SearchSortedArrayForFirstElementLargerThanK
    {
        public static int IndexOf(int[] a, int k)
        {
            var n = a.Length;
            var l = 0;
            var h = n;
            while (!(a[l] <= k && a[l+1] > k))
            {
                var m = (l + h)/2;
                if (a[m] <= k)
                {
                    l = m;
                }
                else
                {
                    h = m;
                }
            }
            return l + 1;
        }
    }
}
