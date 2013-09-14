using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms.Code
{
    /// <summary>
    ///     In most states, gamblers can choose from a wide variety of different lottery games.
    ///     The rules of a lottery are defined by two integers (choices and blanks) and two boolean variables (sorted and unique).
    ///     choices represents the highest valid number that you may use on your lottery ticket.
    ///     (All integers between 1 and choices, inclusive, are valid and can appear on your ticket.)
    ///     blanks represents the number of spots on your ticket where numbers can be written.
    ///     The sorted and unique variables indicate restrictions on the tickets you can create.
    ///     If sorted is set to true, then the numbers on your ticket must be written in non-descending order.
    ///     If sorted is set to false, then the numbers may be written in any order.
    ///     Likewise, if unique is set to true, then each number you write on your ticket must be distinct.
    ///     If unique is set to false, then repeats are allowed.
    ///     Here are some example lottery tickets, where choices = 15 and blanks = 4:
    ///     {3, 7, 12, 14} -- this ticket is unconditionally valid.
    ///     {13, 4, 1, 9} -- because the numbers are not in nondescending order, this ticket is valid only if sorted = false.
    ///     {8, 8, 8, 15} -- because there are repeated numbers, this ticket is valid only if unique = false.
    ///     {11, 6, 2, 6} -- this ticket is valid only if sorted = false and unique = false.
    ///     Given a list of lotteries and their corresponding rules, return a list of lottery names sorted by how easy they are to win.
    ///     The probability that you will win a lottery is equal to (1 / (number of valid lottery tickets for that game)).
    ///     The easiest lottery to win should appear at the front of the list. Ties should be broken alphabetically (see example 1).
    ///     Constraints
    ///     rules will contain between 0 and 50 elements, inclusive.
    ///     Each element of rules will contain between 11 and 50 characters, inclusive.
    ///     Each element of rules will be in the format "&lt;NAME&gt;:_&lt;CHOICES&gt;_&lt;BLANKS&gt;_&lt;SORTED&gt;_&lt;UNIQUE&gt;" (quotes for clarity).
    ///     The underscore character represents exactly one space. The string will have no leading or trailing spaces.
    ///     &lt;NAME&gt; will contain between 1 and 40 characters, inclusive, and will consist of only uppercase letters ('A'-'Z') and spaces (' '),
    ///     with no leading or trailing spaces.
    ///     &lt;CHOICES&gt; will be an integer between 10 and 100, inclusive, with no leading zeroes.
    ///     &lt;BLANKS&gt; will be an integer between 1 and 8, inclusive, with no leading zeroes.
    ///     &lt;SORTED&gt; will be either 'T' (true) or 'F' (false).
    ///     &lt;UNIQUE&gt; will be either 'T' (true) or 'F' (false).
    ///     No two elements in rules will have the same name.
    /// </summary>
    public class Lottery
    {
        public string[] SortByOdds(string[] rules)
        {
            var l = new Dictionary<string, double>();
            foreach (Rule r in rules.Select(Rule.Parse))
            {
                double o;
                double t = Math.Pow(r.Choices, r.Blanks);
                if (!r.Sorted && !r.Unique)
                {
                    o = 1/t;
                }
                else if (r.Sorted && !r.Unique)
                {
                    o = 1/(t - BinomialCoefficient(r.Choices, r.Blanks));
                }
                else if (!r.Sorted && r.Unique)
                {
                    o = 1/(t - r.Choices);
                }
                else
                {
                    o = 1/(t - MultisetCoefficient(r.Choices, r.Blanks));
                }
                l.Add(r.Name, o);
            }
            return (from x in l
                    orderby x.Value descending, x.Key ascending
                    select x.Key).ToArray();
        }

        public static double Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n", "n >= 0 required");
            }
            if (n < 2)
            {
                return 1;
            }
            double h = n/2D;
            double q = h*h;
            double r = (n & 1) == 1 ? 2*q*n : 2*q;
            double f = r;
            for (int d = 1; d < n - 2; d += 2)
            {
                f *= q -= d;
            }
            return f;
        }

        public static double BinomialCoefficient(int n, int k)
        {
            double s = 0D;
            for (int i = 0; i < k; i++)
            {
                s += Math.Log10(n - i);
                s -= Math.Log10(i + 1);
            }
            return Math.Pow(10, s);
        }

        public static double MultisetCoefficient(int n, int k)
        {
            return Factorial((n + k) - 1)/(Factorial(n - 1)*Factorial(k));
        }

        public class Rule
        {
            public string Name { get; set; }
            public int Choices { get; set; }
            public int Blanks { get; set; }
            public bool Sorted { get; set; }
            public bool Unique { get; set; }

            public static Rule Parse(string rule)
            {
                Rule r = default(Rule);
                const string p = @"^(?<n>(\w+\s*)+)(:\s)+(?<c>\d+)\s+(?<b>\d+)\s+(?<s>[TF]+)\s+(?<u>[TF]+)$";
                Match m = new Regex(p).Match(rule);
                if (m.Success)
                {
                    r = new Rule
                        {
                            Name = m.Groups["n"].Value,
                            Choices = Convert.ToInt32(m.Groups["c"].Value),
                            Blanks = Convert.ToInt32(m.Groups["b"].Value),
                            Sorted = m.Groups["s"].Value == "T",
                            Unique = m.Groups["u"].Value == "T"
                        };
                }
                return r;
            }
        }
    }
}