using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Sorting
{
    public static class InsertionSort
    {
        public static void Sort(int[] array)
        {
            var n = array.Length;
            for (var i = 1; i < n; i++)
            {
                var v = array[i];
                var h = i;
                while (h > 0 && v < array[h - 1])
                {
                    array[h] = array[h - 1];
                    h--;
                }
                array[h] = v;
            }
        }
    }
}
