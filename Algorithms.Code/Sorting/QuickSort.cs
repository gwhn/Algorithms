using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Sorting
{
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            var n = array.Length;
            if (n < 2)
            {
                return array;
            }
            var m = n/2;
            var middle = array[m];
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i != m)
                {
                    if (array[i] <= middle)
                    {
                        left.Add(array[i]);
                    }
                    else
                    {
                        right.Add(array[i]);
                    }
                }
            }
            return Sort(left.ToArray())
                .Concat(new[]{middle})
                .Concat(Sort(right.ToArray()))
                .ToArray();
        }
    }
}
