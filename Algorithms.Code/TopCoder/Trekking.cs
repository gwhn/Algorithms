using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are planning a small trek over at the local mountain range. 
    /// It will involve walking for several days and spending the nights in a tent. 
    /// The mountains are not very friendly (they're steep and rocky), 
    /// and therefore many locations are not suitable for setting up a camp. 
    /// You will be given a String trail which represents the locations in the order in which you are visiting them. 
    /// trail[i] is '.' if it's possible to camp at the i-th location, and '^' otherwise.
    /// You have several alternative plans to follow, given in the String[] plans. 
    /// plans[i][j] is lowercase 'w' if according to the i-th plan you are going to walk through location j, 
    /// and uppercase 'C' if you are going to camp there. 
    /// A plan is invalid if it involves camping at a location that's not suitable for it.
    /// Given trail and plans return the minimum number of nights that must be spent in the mountains, 
    /// according to one of the valid plans. 
    /// If all plans are invalid, return -1
    /// 
    /// Constraints
    /// trail will contain between 2 and 50 characters, inclusive.
    /// trail will contain only the characters '.' and '^'.
    /// plans will contain between 2 and 50 elements, inclusive.
    /// Each element of plans will contain the same number of characters as trail.
    /// Each element of plans will contain only the characters 'w' and 'C'.
    /// </summary>
    public class Trekking
    {
        public int FindCamps(String trail, String[] plans)
        {
            var n = trail.Length;
            var m = plans.Length;
            var min = int.MaxValue;
            for (int i = 0; i < m; i++)
            {
                var count = 0;
                var plan = plans[i];
                for (int j = 0; j < n; j++)
                {
                    char activity = plan[j];
                    if (activity == 'C')
                    {
                        char terrain = trail[j];
                        if (terrain == '^')
                        {
                            count = -1;
                            break;
                        }
                        if (terrain == '.')
                        {
                            count++;
                        }
                    }
                }
                if (count >= 0)
                {
                    min = Math.Min(min, count);                    
                }
            }
            return min == int.MaxValue ? -1 : min;
        }
    }
}
