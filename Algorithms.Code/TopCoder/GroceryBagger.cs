using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You have just begun working as a grocery bagger at the local TopGrocer food store. 
    /// Your job is to place all of a customer's items into bags, so they can be carried from the store. 
    /// Your manager has instructed you to use as few bags as possible, to minimize the store's overall cost. 
    /// However, for the customer's convenience, 
    /// you are instructed that only items of the same type can be placed in the same bag. 
    /// For instance, a produce item can be bagged with any other produce items, but not with dairy items.
    /// You are given a String[] itemType indicating the type of each item that needs to be bagged. 
    /// You are also given an int strength indicating the maximum number of items that can be placed in each bag. 
    /// You are to return an int indicating the minimum number of bags required to package the customer's items.
    /// 
    /// Constraints 
    /// strength will be between 1 and 50, inclusive. 
    /// itemType will contain between 0 and 50 elements, inclusive. 
    /// Each element of itemType will contain between 1 and 50 characters, inclusive. 
    /// Each element of itemType will contain only the characters 'A'-'Z'. 
    /// </summary>
    public class GroceryBagger
    {
        public int MinimumBags(int strength, String[] itemType)
        {
            var n = itemType.Length;
            var count = 0;
            var list = new SortedList<string, int>();
            for (int i = 0; i < n; i++)
            {
                string key = itemType[i];
                if (!list.ContainsKey(key))
                {
                    list.Add(key, 1);
                }
                else
                {
                    list[key]++;
                }
            }
            foreach (var item in list)
            {
                var v = item.Value;
                var d = v/strength;
                var r = v%strength;
                count += d;
                if (r > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
