using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are given two Strings: init and goal. 
    /// Both init and goal contain lowercase letters only. 
    /// Additionally, init does not contain the character 'z'.
    /// Your goal is to transform init into goal. 
    /// The only operation you are allowed to do is to insert the character 'z' anywhere into init. 
    /// You can repeat the operation as many times as you want, 
    /// and each time you can choose any position where to insert the 'z'.
    /// For example, if init="fox", you can transform it to "fzox" in one operation. 
    /// Alternately, you can transform "fox" into "zzzfoxzzz" in six operations. 
    /// It is not possible to transform "fox" into any of the strings "fx", "foz", "fxo", "foxy".
    /// Return "Yes" (quotes for clarity) if it is possible to transform init into goal. Otherwise, return "No".
    /// 
    /// Notes
    /// Note that the return value is case sensitive.
    /// 
    /// Constraints
    /// init and goal will each contain between 1 and 50 characters, inclusive.
    /// Each character of init and goal will be a lowercase letter ('a'-'z').
    /// init will not contain the letter 'z'.
    /// </summary>
    public class InsertZ
    {
        public String CanTransform(String init, String goal)
        {
            var ok = true;
            int n = init.Length;
            int m = goal.Length;
            if (n > m)
            {
                return "No";
            }
            for (int i = 0, j = 0; i < n && j < m;)
            {
                char a = init[i];
                char b = goal[j];
                if (a == b)
                {
                    i++;
                    j++;
                }
                else if (b == 'z')
                {
                    j++;
                }
                else
                {
                    ok = false;
                    break;
                }
            }
            return ok ? "Yes" : "No";
        }
    }
}
