using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are interested in purchasing items from a number of stores in a local market. 
    /// The market is composed of N stores numbered from 0 to N-1. 
    /// The stores with numbers from 0 to M-1 are interesting to you and all the other stores are not interesting. 
    /// Some pairs of stores are connected by roads. 
    /// You are given a String[] interestingStores which contains M elements and describes the interesting stores. 
    /// The i-th element corresponds to store i and is formatted "OPEN CLOSE DURATION" (quotes for clarity), 
    /// where OPEN is the opening time (in seconds), 
    /// CLOSE is the closing time (in seconds) and 
    /// DURATION is the time (in seconds) required to make a purchase in this store. 
    /// You can initiate a purchase from a store at any time T between OPEN and CLOSE, inclusive. 
    /// In order to do so, you need to arrive to the store at time T (or earlier). 
    /// The purchase will be finalized at time T + DURATION and you need to stay at the store for the entire duration of your purchase. 
    /// Note that it is possible for a purchase to end when the store is already closed. 
    /// You cannot make multiple purchases in the same store. 
    /// The roads are given by the String[] roads. 
    /// Each element of roads describes a single bidirectional road and is formatted "A B LENGTH" (quotes for clarity). 
    /// Here A and B are the numbers of stores connected by the road and LENGTH is the time (in seconds) 
    /// required to move from A to B (or from B to A) using this road. 
    /// Your start at time 0 at the location of store N-1. 
    /// Return the maximum number of purchases in interesting stores that you can make. 
    /// 
    /// Notes 
    /// You are allowed to wait for any amount of time at any location. 
    /// 
    /// Constraints 
    /// N will be between 1 and 50, inclusive. 
    /// roads will contain between 1 and 50 elements, inclusive. 
    /// Each element of roads will be formatted "A B LENGTH" (quotes for clarity), 
    /// where A, B and LENGTH are integers with no unnecessary leading zeros. 
    /// In each road, A and B will each be between 0 and N-1, inclusive. 
    /// In each road, A and B will be distinct. 
    /// In each road, LENGTH will be between 1 and 604,800, inclusive. 
    /// There will exist at most one road between each pair of stores. 
    /// interestingStores will contain between 1 and min{16, N} elements, inclusive, 
    /// Each element of interestingStores will be formatted "OPEN CLOSE DURATION" (quotes for clarity), 
    /// where OPEN, CLOSE and DURATION are integers with no unnecessary leading zeros. 
    /// In each store, OPEN will be between 0 and 604,800, inclusive. 
    /// In each store, CLOSE will be between OPEN+1 and 604,800, inclusive. 
    /// In each store, DURATION will be between 1 and 604,800, inclusive. 
    /// </summary>
    public class TravellingPurchasingMan
    {
        public int MaxStores(int n, String[] interestingStores, String[] roads)
        {
            var matrix = new int[n,n];
            foreach (var road in roads)
            {
                var split = road.Split(' ');
                var a = Convert.ToInt32(split[0]);
                var b = Convert.ToInt32(split[1]);
                var t = Convert.ToInt32(split[2]);
                matrix[a, b] = matrix[b, a] = t;
            }
            throw new NotImplementedException();
        }
    }
}
