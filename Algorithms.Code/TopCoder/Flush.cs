using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are playing a card game in which large flushes, or sets of cards of the same suit, are beneficial. 
    /// Your next move is to draw number cards: 
    ///     the larger the flush you get, the better. 
    /// You wish to know the expected size of the largest flush in the cards you draw. 
    /// The deck will consist of some number of cards of four suits, given as suits. 
    /// The ith element of suits is the number of cards of that suit in the deck. 
    /// Return a double, the expected size of the largest flush your hand will make.  
    /// The expected size of the largest flush is calculated as follows: 
    ///     For each possible hand, 
    ///     multiply the size of the largest flush in that hand by the probability of getting that hand. 
    ///     Then add all of these values together to get the expected size of the largest flush. 
    /// For example, if half of the possible hands give you a flush of size 3, 
    /// and the rest give you one of size 2, the expected value is (0.5 * 3) + (0.5 * 2) = 2.5. 
    /// Also, recall that there are n Choose k = n!/k!/(n-k)! ways to select k cards of one suit out of a total of n cards 
    /// in that suit, where ! denotes the factorial operation. 
    /// Thus, if suits = {3,3,3,3}, 
    /// then there are (3 Choose 3) * (3 Choose 2) * (3 Choose 1) * (3 Choose 0) = 1 * 3 * 3 * 1 = 9 
    /// ways to get 3 cards of the first suit, 2 of the second, 1 of the third, and none of the fourth.
    /// 
    /// Notes
    /// Look out for overflow! A 32-bit datatype may not be large enough.
    /// Your return value must have an absolute or relative error less than 1e-9.
    /// 
    /// Constraints
    /// suits will contain exactly four elements.
    /// Each element of suits is between 0 and 13, inclusive.
    /// number is between 0 and the sum of the elements of suits, inclusive.
    /// </summary>
    public class Flush
    {
        public double Size(int[] suits, int number)
        {
            long sum = 0;
            long total = 0;
            for (int i = 0; i <= suits[0]; i++)
            {
                for (int j = 0; j <= suits[1]; j++)
                {
                    for (int k = 0; k <= suits[2]; k++)
                    {
                        int l = number - i - j - k;
                        if (l >= 0 && l <= suits[3])
                        {
                            long a = Choose(suits[0], i)*Choose(suits[1], j)*Choose(suits[2], k)*Choose(suits[3], l);
                            total += a;
                            sum += a*Math.Max(i, Math.Max(j, Math.Max(k, l)));
                        }
                    }
                }
            }
            return (double) sum/total;
        }

        private long Choose(int n, int k)
        {
            long result = 1;
            for (int i = 1, j = n; i <= k; i++, j--)
            {
                result *= j;
                result /= i;
            }
            return result;
        }
    }
}
