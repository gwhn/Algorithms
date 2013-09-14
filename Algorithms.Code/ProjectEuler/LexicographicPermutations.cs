using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// A permutation is an ordered arrangement of objects. 
    /// For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
    /// If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. 
    /// The lexicographic permutations of 0, 1 and 2 are:
    /// 012   021   102   120   201   210
    /// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    /// </summary>
    public class LexicographicPermutations
    {
        public string Solve(int[] s, int t)
        {
            // Sort the sequence in weakly increasing order giving the lexicographic minimal permutation
            Array.Sort(s);
            var i = 1;
            var n = s.Length;
            while (i < t)
            {
                // Find the largest index k such that s[k] < s[k+1]
                var ok = false;
                var k = n - 2;
                for (int j = k; j >= 0 ; j--)
                {
                    if (s[j] < s[j+1])
                    {
                        k = j;
                        ok = true;
                        break;
                    }
                }
                // If no such index exists, the permutation is the the last one
                if (!ok)
                {
                    return string.Empty;
                }
                // Find the largest index l such that s[k] < s[l]
                var l = 0;
                for (int j = n - 1; j >= 0; j--)
                {
                    if (s[k] < s[j])
                    {
                        l = j;
                        break;
                    }
                }
                // Swap the value of s[k] with that of s[l]
                var x = s[k];
                s[k] = s[l];
                s[l] = x;
                // Reverse the sequence from s[k+1] up to and including the final element s[n-1]
                var m = (n - (k + 1))/2;
                for (int j = 0; j < m; j++)
                {
                    x = s[k + 1 + j];
                    s[k + 1 + j] = s[n - 1 - j];
                    s[n - 1 - j] = x;
                }
                i++;
            }
            return s.Aggregate("", (x, c) => x + c);
        }
    }
}
