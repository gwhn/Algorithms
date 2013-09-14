using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You work for an electric company, and the power goes out in a rather large apartment complex with a lot of irate tenants. 
    /// You isolate the problem to a network of sewers underneath the complex with a step-up transformer at every junction in the maze of ducts. 
    /// Before the power can be restored, every transformer must be checked for proper operation and fixed if necessary. 
    /// To make things worse, the sewer ducts are arranged as a tree with the root of the tree at the entrance to the network of sewers. 
    /// This means that in order to get from one transformer to the next, there will be a lot of backtracking through the long and 
    /// claustrophobic ducts because there are no shortcuts between junctions. 
    /// Furthermore, it's a Sunday; you only have one available technician on duty to search the sewer network for the bad transformers. 
    /// Your supervisor wants to know how quickly you can get the power back on; he's so impatient that he wants the power back on the moment 
    /// the technician okays the last transformer, without even waiting for the technician to exit the sewers first.
    /// You will be given three int[]'s: fromJunction, toJunction, and ductLength that represents each sewer duct. 
    /// Duct i starts at junction (fromJunction[i]) and leads to junction (toJunction[i]). ductlength[i] represents the amount of minutes 
    /// it takes for the technician to traverse the duct connecting fromJunction[i] and toJunction[i]. Consider the amount of time it takes 
    /// for your technician to check/repair the transformer to be instantaneous. 
    /// Your technician will start at junction 0 which is the root of the sewer system. 
    /// Your goal is to calculate the minimum number of minutes it will take for your technician to check all of the transformers. 
    /// You will return an int that represents this minimum number of minutes.
    /// 
    /// Constraints
    /// fromJunction will contain between 1 and 50 elements, inclusive.
    /// toJunction will contain between 1 and 50 elements, inclusive.
    /// ductLength will contain between 1 and 50 elements, inclusive.
    /// toJunction, fromJunction, and ductLength must all contain the same number of elements.
    /// Every element of fromJunction will be between 0 and 49 inclusive.
    /// Every element of toJunction will be between 1 and 49 inclusive.
    /// fromJunction[i] will be less than toJunction[i] for all valid values of i.
    /// Every (fromJunction[i],toJunction[i]) pair will be unique for all valid values of i.
    /// Every element of ductlength will be between 1 and 2000000 inclusive.
    /// The graph represented by the set of edges (fromJunction[i],toJunction[i]) will never contain a loop, 
    /// and all junctions can be reached from junction 0.
    /// </summary>
    public class PowerOutage
    {
        public int EstimateTimeOut(int[] fromJunction, int[] toJunction, int[] ductLength)
        {
            var ls = new int[50];
            var k = fromJunction.Length;
            var sm = ductLength.Sum();
            var ml = 0;
            ls[0] = 0;
            for (var i = 0; i < 50; i++)
            {
                for (var j = 0; j < k; j++)
                {
                    if (toJunction[j] == i)
                    {
                        ls[i] = ls[fromJunction[j]] + ductLength[j];
                        break;
                    }
                }
                ml = Math.Max(ml, ls[i]);
            }
            return 2*sm - ml;
        }
    }
}
