using System.Linq;

namespace Algorithms.Code
{
    /// <summary>
    /// This task is about the scoring in the first phase of the die-game Yahtzee, where five dice are used. 
    /// The score is determined by the values on the upward die faces after a roll. 
    /// The player gets to choose a value, and all dice that show the chosen value are considered active. 
    /// The score is simply the sum of values on active dice.
    /// Say, for instance, that a player ends up with the die faces showing 2, 2, 3, 5 and 4. 
    /// Choosing the value two makes the dice showing 2 active and yields a score of 2 + 2 = 4, 
    /// while choosing 5 makes the one die showing 5 active, yielding a score of 5.
    /// Your method will take as input a int[] toss, where each element represents the upward face of a die, 
    /// and return the maximum possible score with these values.
    /// 
    /// Constraints
    /// toss will contain exactly 5 elements.
    /// Each element of toss will be between 1 and 6, inclusive.
    /// </summary>
    public class YahtzeeScore
    {
        public int MaxPoints(int[] toss)
        {
            var n = toss.Length;
            var used = Enumerable.Repeat(false, n).ToArray();
            var max = 0;
            for (var i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    var current = toss[i];
                    used[i] = true;
                    for (var j = i + 1; j < n; j++)
                    {
                        if (!used[j] && toss[i] == toss[j])
                        {
                            current += toss[j];
                            used[j] = true;
                        }
                    }
                    if (current > max)
                    {
                        max = current;
                    }
                }
            }
            return max;
        }
    }
}
