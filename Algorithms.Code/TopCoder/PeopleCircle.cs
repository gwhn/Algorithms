using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// There are numMales males and numFemales females arranged in a circle. Starting from a given point, 
    /// you count clockwise and remove the K'th person from the circle (where K=1 is the person at the current point, 
    /// K=2 is the next person in the clockwise direction, etc...). 
    /// After removing that person, the next person in the clockwise direction becomes the new starting point. 
    /// After repeating this procedure numFemales times, there are no females left in the circle.
    /// Given numMales, numFemales and K, your task is to return what the initial arrangement of people in the circle must have been, 
    /// starting from the starting point and in clockwise order.
    /// For example, if there are 5 males and 3 females and you remove every second person, your return String will be "MFMFMFMM".
    /// 
    /// Constraints
    /// numMales is between 0 and 25 inclusive
    /// numFemales is between 0 and 25 inclusive
    /// K is between 1 and 1000 inclusive
    /// </summary>
    public class PeopleCircle
    {
        public String Order(int numMales, int numFemales, int k)
        {
            var n = numMales + numFemales;
            var answer = Enumerable.Repeat('M', n).ToArray();
            var gone = Enumerable.Repeat(false, n).ToArray();
            var pos = 0;
            for (var i = 0; i < numFemales; i++)
            {
                var j = k;
                while (j > 1 || gone[pos])
                {
                    if (!gone[pos])
                    {
                        j--;
                    }
                    pos = (pos + 1)%n;
                }
                answer[pos] = 'F';
                gone[pos] = true;
                pos = (pos + 1)%n;
            }
            return new string(answer);
        }

        // This brute force method fails Test3 and is really inefficient
        //public String Order(int numMales, int numFemales, int k)
        //{
        //    var a = new[] {'M', 'F'};
        //    var l = a.Length;
        //    var n = numMales + numFemales;
        //    var p = Convert.ToInt32(Math.Pow(l, n));
        //    var t = new char[p,n];
        //    var r = string.Empty;
        //    // Generate all permutations with repetition
        //    for (var i = 0; i < n; i++)
        //    {
        //        var t2 = Convert.ToInt32(Math.Pow(l, i));
        //        for (var p1 = 0; p1 < p;)
        //        {
        //            for (var al = 0; al < l; al++)
        //            {
        //                for (var p2 = 0; p2 < t2; p2++)
        //                {
        //                    t[p1, i] = a[al];
        //                    p1++;
        //                }
        //            }
        //        }
        //    }
        //    // Find valid permutations
        //    var ss = new List<string>();
        //    for (int i = 0; i < t.GetLongLength(0); i++)
        //    {
        //        var w = "";
        //        var m = 0;
        //        var f = 0;
        //        for (int j = 0; j < t.GetLongLength(1); j++)
        //        {
        //            if (t[i, j] == a[0])
        //            {
        //                m++;
        //            } 
        //            else if (t[i, j] == a[1])
        //            {
        //                f++;
        //            }
        //            w += t[i, j];
        //        }
        //        if (m == numMales && f == numFemales)
        //        {
        //            ss.Add(w);
        //        }
        //    }
        //    foreach (var s in ss)
        //    {
        //        var x = s;
        //        var y = k - 1;
        //        var m = true;
        //        for (var j = 0; j < numFemales; j++)
        //        {
        //            if (x[y] != a[1])
        //            {
        //                m = false;
        //                break;
        //            }
        //            x = x.Remove(y, 1);
        //            y = (y + k) - 1;
        //            var z = x.Length;
        //            if (y > z - 1)
        //            {
        //                y = z%k;
        //            }
        //        }
        //        if (m)
        //        {
        //            r = s;
        //        }
        //    }
        //    return r;
        //}
    }
}
