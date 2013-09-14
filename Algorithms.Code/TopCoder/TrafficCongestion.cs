using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// There are some cities and some roads connecting them together. 
    /// The road network has the topology of a perfect binary tree (see below for a picture), 
    /// in which the cities are nodes and the roads are edges.
    /// You are given the int treeHeight giving the height of the tree. 
    /// (The height of a perfect binary tree is the number of edges on the path between the root node and any leaf node.) 
    /// Thus, there are 2^(treeHeight+1)-1 cities and 2^(treeHeight+1)-2 roads in total.
    /// The picture below shows how the road network looks like when treeHeight = 2.
    /// We want to send some cars into the road network. 
    /// Each car will be traveling from its starting city to its destination city without visiting the same city twice. 
    /// (Note that the route of each car is uniquely determined by its starting and its destination city.) 
    /// It is possible for the starting city to be equal to the destination city, 
    /// in that case the car only visits that single city.
    /// Our goal is to send out the cars in such a way that each city will be visited by exactly one car. 
    /// Let X be the smallest number of cars we need in order to do so. 
    /// Compute and return the value X modulo 1,000,000,007.
    /// 
    /// Constraints 
    /// treeHeight will be between 0 and 1,000,000, inclusive. 
    /// </summary>
    public class TrafficCongestion
    {
        public int TheMinCars(int treeHeight)
        {
            long ret = 0;
            const long mod = 1000000007;
            if (treeHeight % 2 == 1)
            {
                long now = 1;
                for (int i = 1; i <= treeHeight; i += 2)
                {
                    ret += now;
                    ret %= mod;
                    now *= 4;
                    now %= mod;
                }
            }
            else
            {
                ret = 1;
                long now = 2;
                for (int i = 2; i <= treeHeight; i += 2)
                {
                    ret += now;
                    ret %= mod;
                    now *= 4;
                    now %= mod;
                }
            }
            return (int)ret;
        }
    }
}
