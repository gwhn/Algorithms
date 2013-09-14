using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms.Code
{
    /// <summary>
    /// A certain vending machine delves out its goods from a rotating cylinder, which can rotate around in both clockwise and 
    /// counter-clockwise directions. 
    /// The cylinder has a number of shelves on it, and each shelf is divided into a number of columns. 
    /// On the front of the machine, there is a panel of doors that extends the entire height of the column. 
    /// There is one door for each shelf, which is the width of one column. 
    /// When a purchase is made, the user uses two buttons to rotate the cylinder so their purchase is located at a door. 
    /// They make their purchase by sliding the appropriate door open, and removing the item 
    /// (there can only be one item per column on a particular shelf). 
    /// The cylinder can rotate in a complete circle, and so there are always two ways to get from a particular column to another column.
    /// Because the vending machine company wants to sell the most expensive items possible, and the machine can only show one column at 
    /// a time, the machine will always try to put forth the most expensive column available. 
    /// The price of a column is calculated by adding up all the prices of the remaining items in that column. 
    /// The most expensive column is defined to be the one with the maximum price. 
    /// If 5 minutes have elapsed since the last purchase was made, the machine rotates the cylinder to the most expensive column. 
    /// If, however, another purchase has been made before the 5 minutes are up, the rotation does not occur, and the 5 minute timer is reset.
    /// Recently, some machines' rotating motors have been failing early, and the company wants to see if it is because the machines rotate 
    /// to show their expensive column too often. 
    /// To determine this, they have hired you to simulate purchases and see how long the motor is running.
    /// You will be given the prices of all the items in the vending machine in a String[]. 
    /// Each element of prices will be a single-space separated list of integers, which are the prices (in cents) of the items. 
    /// The Nth integer in the Mth element of prices represents the price of the Nth column in the Mth shelf in the cylinder. 
    /// You will also be given a String[] purchases. 
    /// Each element in purchases will be in the format: "&lt;shelf&gt;,&lt;column&gt;:&lt;time&gt;" 
    /// &lt;shelf&gt; is a 0-based integer which identifies the shelf that the item was purchased from. 
    /// &lt;column&gt; is a 0-based integer which identifies the column the item was purchased from. 
    /// &lt;time&gt; is an integer which represents the time, in minutes, since the machine was turned on.
    /// In the simulation, the motor needs to run for 1 second in order to rotate to an adjacent column. 
    /// When the machine is turned on, column 0 is facing out, and it immediately rotates to the most expensive column, 
    /// even if the first purchase is at time 0. 
    /// The machine also rotates to the most expensive column at the end of the simulation, after the last purchase. 
    /// Note that when an item is purchased, its price is no longer used in calculating the price of the column it is in. 
    /// When the machine rotates to the most expensive column, or when a user rotates the cylinder, 
    /// the rotation is in the direction which takes the least amount of time. 
    /// For example, in a 4-column cylinder, if column 0 is displayed, and the cylinder is rotated to column 3, 
    /// it can be rotated backwards, which takes 1 second, versus rotating forwards which takes 3 seconds.
    /// If a user tries to purchase an item that was already purchased, this is an incorrect simulation, and your method should return -1. 
    /// Otherwise, your method should return how long the motor was running, in seconds.
    ///     
    /// Notes
    /// When rotating to the most expensive column, if two columns have the same price, 
    /// rotate to the one with the lowest column number.
    /// If two purchases are less than 5 minutes apart, the machine does not perform a rotation to the most expensive 
    /// column between the purchases. 
    /// If two purchases are 5 or more minutes apart, the machine rotates to the most expensive column between the two purchases.
    /// 
    /// Constraints
    /// prices will have between 1 and 50 elements, inclusive.
    /// Each element of prices will have between 5 and 50 characters, is a single-space separated list of integers, 
    /// and has no leading or trailing spaces.
    /// Each element of prices will have the same number of integers in it.
    /// Each element of prices will have at least 3 integers in it.
    /// Each integer in prices will be between 1 and 10000, inclusive, and will not contain leading 0's.
    /// purchases will have between 1 and 50 elements, inclusive.
    /// Each element of purchases will be in the format "&lt;shelf&gt;,&lt;column&gt;:&lt;time&gt;", 
    /// where &lt;shelf&gt;, &lt;column&gt;, and &lt;time&gt; are all integers.
    /// In each element of purchases, &lt;shelf&gt; will be between 0 and M - 1, inclusive, where M is the number of elements in prices.
    /// In each element of purchases, &lt;column&gt; will be between 0 and N - 1, inclusive, where N is the number of integers in each 
    /// element of prices.
    /// In each element of purchases, &lt;time&gt; will be between 0 and 1000, inclusive.
    /// In each element of purchases, &lt;shelf&gt;, &lt;column&gt;, and &lt;time&gt; will not contain extra leading 0's.
    /// purchases will be sorted in strictly ascending order by &lt;time&gt;. 
    /// This means that each purchase must occur later than all previous ones.
    /// </summary>
    public class VendingMachine
    {
        public int MotorUse(String[] prices, String[] purchases)
        {
            var prs = ParsePrices(prices);
            var shs = prs.Length;
            var cols = prs[0].Length;
            var pus = ParsePurchases(purchases);
            var cur = 0;
            var tot = Rotate(ref cur, MostExpensiveColumn(prs), cols);
            var n = pus.Length;
            for (var i = 0; i < n; i++)
            {
                if (prs[pus[i][0]][pus[i][1]] == 0)
                {
                    return -1;
                }
                tot += Rotate(ref cur, pus[i][1], cols);
                prs[pus[i][0]][pus[i][1]] = 0;
                if (i + 1 > n - 1 || pus[i + 1][2] - pus[i][2] >= 5)
                {
                    tot += Rotate(ref cur, MostExpensiveColumn(prs), cols);
                }
            }
            return tot;
        }

        private static int Rotate(ref int fromColumn, int toColumn, int columnCount)
        {
            var t = 0;
            if (fromColumn != toColumn)
            {
                var cw = 0;
                var aw = 0;
                if (fromColumn > toColumn)
                {
                    cw = columnCount + toColumn - fromColumn;
                    aw = fromColumn - toColumn;
                }
                else
                {
                    cw = toColumn - fromColumn;
                    aw = columnCount + fromColumn - toColumn;
                }
                t = cw > aw
                    ? aw
                    : cw;
                fromColumn = toColumn;
            }
            return t;
        }

        private static int MostExpensiveColumn(int[][] prices)
        {
            var m = prices.Length;
            var n = prices[0].Length;
            var cs = new int[n];
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    cs[j] += prices[i][j];
                }
            }
            var x = cs.Max();
            var c = Array.IndexOf(cs, x);
            return c;
        }

        private static int[][] ParsePurchases(string[] purchases)
        {
            var n = purchases.Length;
            var t = new int[n][];
            const string p = @"^(?<s>\d+),(?<c>\d+):(?<t>\d+)$";
            var r = new Regex(p);
            for (var i = 0; i < n; i++)
            {
                var m = r.Match(purchases[i]);
                if (m.Success)
                {
                    t[i] = new int[3];
                    t[i][0] = Convert.ToInt32(m.Groups["s"].Value);
                    t[i][1] = Convert.ToInt32(m.Groups["c"].Value);
                    t[i][2] = Convert.ToInt32(m.Groups["t"].Value);
                }
            }
            return t;
        }

        private static int[][] ParsePrices(string[] prices)
        {
            var m = prices.Length;
            var t = new int[m][];
            for (var i = 0; i < m; i++)
            {
                var ps = prices[i].Split(' ');
                var n = ps.Length;
                t[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    t[i][j] = Convert.ToInt32(ps[j]);
                }
            }
            return t;
        }
    }
}
