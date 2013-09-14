using System;
using System.Linq;

namespace Algorithms.Code
{
    /// <summary>
    /// You have a certain amount of money to give out as a bonus to employees. 
    /// The trouble is, who do you pick to receive what bonus? 
    /// You decide to assign a number of points to each employee, 
    /// which corresponds to how much they helped the company in the last year. 
    /// You are given an int[] points, where each element contains the points earned by the corresponding employee (i.e. points[0] 
    /// is the number of points awarded to employee 0). Using this, you are to calculate the bonuses as follows:
    /// - First, add up all the points, this is the pool of total points awarded. 
    /// - Each employee gets a percentage of the bonus money, equal to the percentage of the point pool that the employee got. 
    /// - Employees can only receive whole percentage amounts, so if an employee's cut of the bonus has a fractional percentage, truncate it. 
    /// - There may be some percentage of bonus left over (because of the fractional truncation). 
    /// If n% of the bonus is left over, give the top n employees 1% of the bonus. 
    /// There will be no more bonus left after this. 
    /// If two or more employees with the same number of points qualify for this "extra" bonus, 
    /// but not enough bonus is left to give them all an extra 1%, give it to the employees that come first in points.
    /// The return value should be a int[], one element per employee in the order they were passed in. 
    /// Each element should be the percent of the bonus that the employee gets.
    /// 
    /// Constraints
    /// points will have between 1 and 50 elements, inclusive.
    /// Each element of points will be between 1 and 500, inclusive.
    /// </summary>
    public class Bonuses
    {
        public int[] GetDivision(int[] points)
        {
            var n = points.Length;
            var s = points.Sum();
            var bs = new int[n];
            for (var i = 0; i < n; i++)
            {
                bs[i] = Convert.ToInt32(Math.Floor((Convert.ToDecimal(points[i])/Convert.ToDecimal(s))*100M));
            }
            var r = 100 - bs.Sum();
            var t = points.OrderByDescending(x => x).Take(r).ToArray();
            var p = -1;
            var j = 0;
            for (int i = 0; i < r; i++)
            {
                var f = t[i] == p 
                    ? j + 1 
                    : 0;
                j = Array.IndexOf(points, t[i], f);
                bs[j]++;
                p = t[i];
            }
            return bs;
        }
    }
}
