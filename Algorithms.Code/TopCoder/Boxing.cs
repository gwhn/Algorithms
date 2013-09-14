using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// In Olympic boxing, there are five judges who press a button 
    /// when they think that a particular boxer has just landed a punch. 
    /// The times of the button presses are recorded, 
    /// and the boxer receives credit for a punch 
    /// if at least three of the judges press their buttons within 1 second of each other. 
    /// This "algorithm" needs a lot of refinement. 
    /// Here is the version that you should implement. 
    /// Find the maximum number of disjoint time intervals 
    /// that can be chosen such that each interval is of duration 1 second or less and 
    /// contains button presses from at least 3 different judges. 
    /// Two intervals are disjoint if every time within one interval 
    /// is strictly less than every time in the other. 
    /// We give the boxer credit for one punch during each interval. 
    /// The duration of an interval is the amount of time 
    /// between the instant when it starts and when it ends, 
    /// and a punch may be included in an interval 
    /// if its recorded time is at the start, end, or in between. 
    /// So, for example, the interval from 1 to 4 has duration 3, 
    /// and a punch recorded at time 1, 2, 3, or 4 is in that interval. 
    /// The intervals 1 to 4 and 5 to 22 are disjoint, 
    /// but the intervals 1 to 4 and 4 to 22 are not disjoint. 
    /// Create a class Boxing that contains a method maxCredit 
    /// that is given five int[]s, a, b, c, d, and e, 
    /// representing the times of the button presses of the five judges in milliseconds. 
    /// The method returns the maximum credits that can be given to the boxer. 
    ///  
    /// Constraints 
    /// Each of the five arguments will contain between 0 and 50 elements inclusive. 
    /// Each element of each of the arguments will be between 0 and 180,000 inclusive. 
    /// The elements within each of the arguments will be in strictly increasing order. 
    /// </summary>
    public class Boxing
    {
        private const int Inf = 1000000;

        public int MaxCredit(int[] a, int[] b, int[] c, int[] d, int[] e)
        {
            var count = 0;
            const int max = 180000;
            for (int i = 0; i <= max; i++)
            {
                var best = new int[5];
                best[0] = BestTime(a, i);
                best[1] = BestTime(b, i);
                best[2] = BestTime(c, i);
                best[3] = BestTime(d, i);
                best[4] = BestTime(e, i);
                Array.Sort(best);
                if (best[2] <= i + 1000)
                {
                    count++;
                    i = best[2];
                }
            }
            return count;
        }

        private int BestTime(int[] times, int finish)
        {
            int n = times.Length;
            for (int i = 0; i < n; i++)
            {
                if (times[i] >= finish)
                {
                    return times[i];
                }
            }
            return Inf;
        }
    }
}
