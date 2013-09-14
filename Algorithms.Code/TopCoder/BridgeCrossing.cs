using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// A well-known riddle goes like this: Four people are crossing an old bridge. 
    /// The bridge cannot hold more than two people at once. 
    /// It is dark, so they can't walk without a flashlight, and they only have one flashlight! 
    /// Furthermore, the time needed to cross the bridge varies among the people in the group. 
    /// For instance, let's say that the people take 1, 2, 5 and 10 minutes to cross the bridge. 
    /// When people walk together, they always walk at the speed of the slowest person. 
    /// It is impossible to toss the flashlight across the bridge, 
    /// so one person always has to go back with the flashlight to the others. 
    /// What is the minimum amount of time needed to get all the people across the bridge?
    /// In this instance, the answer is 17. 
    /// Person number 1 and 2 cross the bridge together, spending 2 minutes. 
    /// Then person 1 goes back with the flashlight, spending an additional one minute. 
    /// Then person 3 and 4 cross the bridge together, spending 10 minutes. 
    /// Person 2 goes back with the flashlight (2 min), and person 1 and 2 cross the bridge together (2 min). 
    /// This yields a total of 2+1+10+2+2 = 17 minutes spent.
    /// You want to create a computer program to help you solve new instances of this problem. 
    /// Given an int[] times, where the elements represent the time each person spends on a crossing, 
    /// your program should return the minimum possible amount of time spent crossing the bridge.
    /// 
    /// Notes
    /// In an optimal solution, exactly two people will be sent across the bridge with the flashlight each time (if possible), 
    /// and exactly one person will be sent back with the flashlight each time. 
    /// In other words, in an optimal solution, you will never send more than one person back from the far side at a time, 
    /// and you will never send less than two people across to the far side each time (when possible).
    /// 
    /// Constraints
    /// times will have between 1 and 6 elements, inclusive.
    /// Each element of times will be between 1 and 100, inclusive.
    /// </summary>
    public class BridgeCrossing
    {
        public int MinTime(int[] times)
        {
            var left = times.OrderBy(x => x).ToList();
            var min1 = left.Take(1).SingleOrDefault();
            var min2 = left.Skip(1).Take(1).SingleOrDefault();
            var right = new List<int>();
            var sum = 0;
            while (left.Count > 0)
            {
                if (left.Count == 1)
                {
                    right.Add(min1);
                    sum += min1;
                    left.Clear();
                }
                else if (left.Count == 2)
                {
                    right.Add(min1);
                    right.Add(min2);
                    sum += min2;
                    left.Clear();
                }
                else if (right.Count == 0)
                {
                    right.Add(min2);
                    sum += min1 + min2;
                    left.Remove(min2);
                }
                else if (right.Contains(min2))
                {
                    var orderByDescending = left.OrderByDescending(x => x);
                    var max1 = orderByDescending.Take(1).SingleOrDefault();
                    var max2 = orderByDescending.Skip(1).Take(1).SingleOrDefault();
                    right.Add(max1);
                    left.Remove(max2);
                    right.Add(max2);
                    left.Remove(max1);
                    left.Add(min2);
                    right.Remove(min2);
                    sum += max1 + min2;
                }
                else
                {
                    var orderByDescending = left.OrderByDescending(x => x);
                    var max1 = orderByDescending.Take(1).SingleOrDefault();
                    right.Add(max1);
                    left.Remove(max1);
                    sum += max1 + min1;
                }
            }
            return sum;
        }
    }
}
