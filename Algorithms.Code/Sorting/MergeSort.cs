using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Sorting
{
    public static class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            var n = array.Length;
            if (n < 2)
            {
                return array;
            }
            var result = new int[n];
            // Divide
            var m = n/2;
            var left = new int[m];
            for (int i = 0; i < m; i++)
            {
                left[i] = array[i];
            }
            left = Sort(left);
            var right = new int[n - m];
            for (int i = 0; i < n - m; i++)
            {
                right[i] = array[i + m];
            }
            right = Sort(right);
            // Conquer
            var c = 0;
            var l = 0;
            var r = 0;
            while (c < n)
            {
                if (l == left.Length)
                {
                    result[c++] = right[r++];
                }
                else if (r == right.Length)
                {
                    result[c++] = left[l++];
                }
                else if (left[l] < right[r])
                {
                    result[c++] = left[l++];
                }
                else
                {
                    result[c++] = right[r++];
                }
            }
            return result;
        }
    }
}
