using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Kawigi's furniture is all in the wrong places in his new apartment. 
    /// He needs to move all of it into the appropriate spots. 
    /// The problem is that he has so much furniture and very limited room to move it in. 
    /// Because of this, the only action he can take to rearrange his furniture is to swap two pieces of furniture.
    /// He would like to exert as little physical effort as possible in doing this task, 
    /// where the effort of swapping two pieces of furniture is defined 
    /// as the sum of the weights of the two objects to be swapped. 
    /// You need to figure out what the minimum effort required to put all of the furniture in the correct places.
    /// You will be given two int[]s, the first is the weights of each piece of furniture 
    /// (element 0 of the int[] will be the weight of furniture 0, 
    /// element 1 will be the weight of furniture 1, etc). 
    /// The second int[] is the location where each piece of furniture is supposed to end up 
    /// (furniture 0 starts out in location 0, furniture 1 starts out in location 1, etc). 
    /// You are to find and return the minimum cost required to put the furniture in their rightful locations.
    /// 
    /// Constraints 
    /// weights and finalPositions will each have between 1 and 50 elements. 
    /// weights and finalPositions will have the same number of elements. 
    /// finalPositions will have the numbers 0 through n-1 inclusive, exactly once, 
    /// where n is the number of elements in the array. 
    /// The elements in weights will be between 1 and 10000. 
    /// </summary>
    public class RearrangeFurniture
    {
        public int LowestEffort(int[] weights, int[] finalPositions)
        {
            int i, j, l, p, n = weights.Length;
            int sum, res;
            int minW, lminW;

            minW = 1 << 30;
            for (i = 0; i < n; i++)
                if (weights[i] < minW) minW = weights[i];
            res = 0;
            for (i = 0; i < n; i++)
                if ((finalPositions[i] != i) && (finalPositions[i] >= 0))
                {
                    l = 1;
                    lminW = weights[i];
                    sum = lminW;
                    j = finalPositions[i];
                    p = i;
                    finalPositions[i] = -1;
                    while (j != p)
                    {
                        l++;
                        if (lminW > weights[j]) lminW = weights[j];
                        sum += weights[j];
                        i = finalPositions[j];
                        finalPositions[j] = -1;
                        j = i;
                    }
                    sum -= lminW;
                    if ((l - 1) * lminW < (l - 1) * minW + 2 * (minW + lminW))
                        res += sum + (l - 1) * lminW;
                    else res += sum + (l - 1) * minW + 2 * (minW + lminW);

                }
            return res;
        }
    }
}
