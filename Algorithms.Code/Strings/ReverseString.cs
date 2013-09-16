using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.Strings
{
    /// <summary>
    /// Iterative and recursive methods to reverse a string
    /// </summary>
    public static class ReverseString
    {
        public static string IterativeReverse(string text)
        {
            var sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        public static string RecursiveReverse(string text)
        {
            if (text.Length < 2)
            {
                return text;
            }
            return RecursiveReverse(text.Substring(1)) + text[0];
        }
    }
}
