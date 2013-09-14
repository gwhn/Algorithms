using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
    /// For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, 
    /// which means that 28 is a perfect number.
    /// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant 
    /// if this sum exceeds n.
    /// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, 
    /// the smallest number that can be written as the sum of two abundant numbers is 24. 
    /// By mathematical analysis, it can be shown that all integers greater than 28123 
    /// can be written as the sum of two abundant numbers. 
    /// However, this upper limit cannot be reduced any further by analysis even though 
    /// it is known that the greatest number that cannot be expressed as the sum of 
    /// two abundant numbers is less than this limit.
    /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    /// </summary>
    public class NonAbundantSums
    {
        public int Solve(int limit)
        {
            var numbers = AbundantNumbers(limit);
            var n = numbers.Count;
            var sums = new bool[limit];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if (sum < limit)
                    {
                        sums[sum] = true;                        
                    }
                }
            }
            var total = 0;
            for (int i = 1; i < limit; i++)
            {
                if (!sums[i])
                {
                    total += i;
                }
            }
            return total;
        }

        private List<int> AbundantNumbers(int limit)
        {
            var list = new List<int>();
            for (int i = 12; i <= limit; i++)
            {
                if (Factors(i).Sum() > i)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private static IEnumerable<int> Factors(int number)
        {
            var list = new List<int>(new[] {1});
            var m = Math.Sqrt(number);
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    list.Add(i);
                    var q = number/i;
                    if (q != i)
                    {
                        list.Add(q);
                    }
                }
            }
            return list;
        }
    }
}
