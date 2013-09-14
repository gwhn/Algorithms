using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Background
    /// I remember a chain problem from my childhood. 
    /// Suppose you have four sections of a golden chain. 
    /// Each consists of three links joined together in a line. 
    /// You would like to connect all four sections into a necklace. 
    /// The obvious solution is to cut the last link of each section and use it to connect the first section to the second one, 
    /// then the second to the third, then the third to the fourth, then the fourth to the first one. 
    /// If you want to minimize the number of cuts, you can do better. 
    /// You can cut one of the three link sections into its individual links. 
    /// Using the three loose links you can join the three remaining sections together.
    /// Your task is, given the lengths of the sections, to return the minimum number of cuts 
    /// to make one big circular necklace out of all of them.
    /// 
    /// Constraints
    /// sections has between 1 and 50 elements inclusive
    /// each element of sections is between 1 and 2,147,483,647 inclusive
    /// the sum of all elements of sections is between 3 and 2,147,483,647 inclusive
    /// </summary>
    public class GoldenChain
    {
        public int MinCuts(int[] sections)
        {
            var n = sections.Length;
            if (n == 1)
            {
                return 1;
            }
            Array.Sort(sections);
            var cum = 0;
            for (var i = 0; i < n; i++)
            {
                var value = sections[i];
                if (value == n - (i+1))
                {
                    return value;
                }
                cum += value;

                if (cum == n - (i + 1))
                {
                    return cum;
                }
            }
            return n - 1;
        }
    }
}
