using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// When a widget breaks, it is sent to the widget repair shop, which is capable of repairing at most numPerDay widgets per day. 
    /// Given a record of the number of widgets that arrive at the shop each morning, 
    /// your task is to determine how many days the shop must operate to repair all the widgets, 
    /// not counting any days the shop spends entirely idle.
    /// For example, suppose the shop is capable of repairing at most 8 widgets per day, 
    /// and over a stretch of 5 days, it receives 10, 0, 0, 4, and 20 widgets, respectively. 
    /// The shop would operate on days 1 and 2, sit idle on day 3, 
    /// and operate again on days 4 through 7. 
    /// In total, the shop would operate for 6 days to repair all the widgets.
    /// Create a class WidgetRepairs containing a method days that takes a sequence of arrival counts arrivals
    /// (of type int[]) and an int numPerDay, and calculates the number of days of operation.
    /// 
    /// Constraints
    /// arrivals contains between 1 and 20 elements, inclusive.
    /// Each element of arrivals is between 0 and 100, inclusive.
    /// numPerDay is between 1 and 50, inclusive.
    /// </summary>
    public class WidgetRepairs
    {
        public int Days(int[] arrivals, int numPerDay)
        {
            var count = 0;
            var n = arrivals.Length;
            var remainder = 0;
            for (int i = 0; i < n; i++)
            {
                var today = arrivals[i] + remainder;
                if (today > 0)
                {
                    count++;
                    remainder = today - numPerDay > 0
                                    ? today - numPerDay
                                    : 0;
                }
            }
            while (remainder > 0)
            {
                count++;
                remainder -= numPerDay;
            }
            return count;
        }
    }
}
