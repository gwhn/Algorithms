using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            var reverse = 0;
            var temp = number;
            while (temp > 0)
            {
                reverse = reverse*10 + temp%10;
                temp /= 10;
            }
            return number == reverse;
        }

        public static bool IsPalindrome(string text)
        {
            int n = text.Length;
            var sb = new StringBuilder(n);
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return text == sb.ToString();
        }
    }
}
