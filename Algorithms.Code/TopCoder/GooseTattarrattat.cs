using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Goose Tattarrattat has a String S of lowercase letters. 
    /// Tattarrattat wants to change her string into a palindrome: 
    /// a string that reads the same forwards and backwards. (For example, "racecar" is a palindrome.)
    /// She will do this in a series of steps. 
    /// In each step, Tattarrattat will choose two letters of the alphabet: X and Y. 
    /// She will then change each X in her string into a Y. 
    /// Changing each single character takes 1 second.
    /// For example, if S="goose" and Tattarrattat chooses X='o' and Y='e' in the next step, 
    /// the step will take 2 seconds (because there are two 'o's in S) and after the step she would have S="geese".
    /// You are given the String S. 
    /// Return the smallest number of seconds in which Tattarrattat can change S into a palindrome.
    /// 
    /// Notes 
    /// Tattarrattat must always change all occurrences of the chosen letter into the other one; 
    /// she is not allowed to change only some of the occurrences. 
    /// 
    /// Constraints 
    /// S will contain between 1 and 50 characters, inclusive. 
    /// Each character in S will be a lowercase letter ('a'-'z'). 
    /// </summary>
    public class GooseTattarrattat
    {
        public int GetMin(String S)
        {
            var count = 0;
            var n = S.Length;
            var m = n/2;
            for (var i = 0; i < m; i++)
            {
                var s1 = S[i];
                var s2 = S[n - 1 - i];
                if (s1 != s2)
                {
                    int c1 = S.Count(x => x == s1);
                    int c2 = S.Count(x => x == s2);
                    if (c1 < c2)
                    {
                        S = S.Replace(s1, s2);
                        count += c1;
                    }
                    else
                    {
                        S = S.Replace(s2, s1);
                        count += c2;
                    }
                }
            }
            return count;
        }
    }
}
