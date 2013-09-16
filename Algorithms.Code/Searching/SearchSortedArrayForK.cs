using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Searching
{
    public static class SearchSortedArrayForK
    {
        public static int IndexOf(int[] a, int k)
        {
            var n = a.Length;
            var l = 0;
            var h = n;
            while (a[l] != k)
            {
                var m = (l + h)/2;
                if (a[m] > k)
                {
                    h = m;
                }
                else
                {
                    l = m;
                }
            }
            return l;
        }
    }
}
