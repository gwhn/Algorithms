using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); 
    /// so the first ten triangle numbers are:
    ///     1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// By converting each letter in a word to a number corresponding to its alphabetical position and 
    /// adding these values we form a word value. 
    /// For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. 
    /// If the word value is a triangle number then we shall call the word a triangle word.
    /// Using words.txt, a 16K text file containing nearly two-thousand common English words, 
    /// how many are triangle words?
    /// </summary>
    public class CodedTriangleNumbers
    {
        public int Solve(string[] words)
        {
            var count = 0;
            var max = words.Select(x => x.Length).Concat(new[] {0}).Max() * 26;
            var lookup = new List<int>(max);
            for (int i = 1; i <= max; i++)
            {
                var v = (i*(i + 1))/2;
                lookup.Add(v);
            }
            foreach (var w in words)
            {
                int l = w.Length;
                var s = 0;
                for (int i = 0; i < l; i++)
                {
                    s += w[i] - 64;
                }
                if (lookup.Contains(s))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
