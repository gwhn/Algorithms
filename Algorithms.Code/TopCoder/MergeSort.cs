using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// MergeSort is a classical sorting algorithm following the divide-and-conquer paradigm. 
    /// Sorting n elements, it has a worst-case complexity of O(n*log(n)), 
    /// which is optimal for sorting algorithms based on comparisons.  
    /// Basically, it sorts a list with more than one element the following way 
    /// (a list containing only one element is always sorted):
    /// 1. divide the list into two sublists of about equal size (divide)
    /// 2. sort each of the two sublists (conquer)
    /// 3. merge the two sorted sublists into one sorted list (combine)
    /// A pro of MergeSort is that it is stable, i.e. elements with the same key value keep their relative order during sorting. 
    /// A con is that it is not in-place since it needs additional space for temporarily storing elements.  
    /// Given a int[] numbers, return the number of comparisons the MergeSort algorithm (as described in pseudocode below) 
    /// makes in order to sort that list. 
    /// In this context, a single comparison takes two numbers x, y (from the list to be sorted) 
    /// and determines which of x < y, x = y and x > y holds.  
    /// List mergeSort(List a)
    /// 1. if size(a) <= 1, return a
    /// 2. split a into two sublists b and c
    ///    if size(a) = 2*k, b contains the first k elements of a, c the last k elements
    ///    if size(a) = 2*k+1, b contains the first k elements of a, c the last k+1 elements
    /// 3. List sb = mergeSort(b)
    ///    List sc = mergeSort(c)
    /// 4. return merge(sb, sc)
    /// List merge(List b, List c)
    /// 1. create an empty list a
    /// 2. while both b and c are not empty, compare the first elements of b and c
    ///    first(b) < first(c): remove the first element of b and append it to the end of a
    ///    first(b) > first(c): remove the first element of c and append it to the end of a
    ///    first(b) = first(c): remove the first elements of b and c and append them to the end of a
    /// 3. if either b or c is not empty, append that non-empty list to the end of a
    /// 4. return a
    /// 
    /// Notes
    /// Be sure to exactly follow the algorithm as described, 
    /// as a different implementation of MergeSort might lead to a different number of comparisons.
    /// 
    /// Constraints
    /// numbers contains between 0 and 50 elements, inclusive.
    /// Each element of numbers is an int in its 'natural' (signed 32-bit) range from -(2^31) to (2^31)-1.
    /// </summary>
    public class MergeSort
    {
        private int _count = 0;

        public int HowManyComparisons(int[] numbers)
        {
            _count = 0;
            var sorted = Sort(new List<int>(numbers));
            return _count;
        }

        private List<int> Sort(List<int> a)
        {
            var n = a.Count;
            if (n <= 1)
            {
                return a;
            }
            var k = n%2 == 0 ? n/2 : n/2 + 1;
            var b = a.Take(k).ToList();
            var c = a.Skip(k).Take(k).ToList();
            var sb = Sort(b);
            var sc = Sort(c);
            var m = Merge(sb, sc);
            return m;
        }

        private List<int> Merge(List<int> b, List<int> c)
        {
            var a = new List<int>();
            while (b.Count > 0 && c.Count > 0)
            {
                _count++;
                if (b[0] < c[0])
                {
                    a.Insert(a.Count, b[0]);
                    b.RemoveAt(0);
                }
                else if (b[0] > c[0])
                {
                    a.Insert(a.Count, c[0]);
                    c.RemoveAt(0);
                }
                else
                {
                    a.Insert(a.Count, b[0]);
                    b.RemoveAt(0);
                    a.Insert(a.Count, c[0]);
                    c.RemoveAt(0);
                }
            }
            if (b.Count > 0)
            {
                a.AddRange(b);
            }
            if (c.Count > 0)
            {
                a.AddRange(c);
            }
            return a;
        }
    }
}
