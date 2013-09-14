using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Once upon a time, there was a kingdom where math was always a big problem. 
    /// When the post of the royal treasurer needed to be filled, 
    /// applicants were presented with the following problem:  
    ///     "We have two arrays of integers, A and B. 
    ///     A and B each contain exactly N elements. 
    ///     Let's define a function S over A and B: 
    /// 	    S = A0*B0 + … + AN-1*BN-1
    ///     Rearrange the numbers in A in such a way that the value of S is as small as possible. 
    ///     You are not allowed to rearrange the numbers in B."  
    /// The problem writers need a program to check the correctness of the applicants' answers. 
    /// Given int[]s A and B, return the smallest possible value for S.
    /// 
    /// Constraints
    /// A will contain between 1 and 50 elements, inclusive.
    /// A and B will contain the same number of elements.
    /// Each element of A will be between 0 and 100, inclusive.
    /// Each element of B will be between 0 and 100, inclusive.
    /// </summary>
    public class RoyalTreasurer
    {
        public int MinimalArrangement(int[] A, int[] B)
        {
            var n = A.Length;
            Array.Sort(A);
            var visited = new bool[n];
            var result = 0;
            for (int i = 0; i < n; i++)
            {
                var k = 0;
                var max = 0;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j])
                    {
                        if (max < B[j])
                        {
                            max = B[j];
                            k = j;
                        }
                        
                    }
                }
                result += A[i]*max;
                visited[k] = true;
            }
            return result;
        }
    }
}
