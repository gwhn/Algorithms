using System;

namespace Algorithms.Code.Sorting
{
    /// <summary>
    /// Implementation of bubble sort algorithm
    /// </summary>
    public static class BubbleSort
    {
        public static void SortIntegers(int[] array)
        {
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        var t = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = t;
                    }
                }
            }
        }

        public static void SortStrings(string[] array)
        {
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (String.Compare(array[j-1], array[j], StringComparison.Ordinal) > 0)
                    {
                        var t = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = t;
                    }
                }
            }
        }
    }
}
