using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    public static class FibonacciSequence
    {
        public static long Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
