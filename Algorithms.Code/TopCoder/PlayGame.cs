using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are playing a computer game and a big fight is planned between two armies. 
    /// You and your computer opponent will line up your respective units in two rows, 
    /// with each of your units facing exactly one of your opponent's units and vice versa. 
    /// Then, each pair of units, who face each other will fight and the stronger one will be victorious, 
    /// while the weaker one will be captured. 
    /// If two opposing units are equally strong, your unit will lose and be captured. 
    /// You know how the computer will arrange its units, and must decide how to line up yours. 
    /// You want to maximize the sum of the strengths of your units that are not captured during the battle. 
    /// You will be given a int[] you and a int[] computer that specify the strengths of the units 
    /// that you and the computer have, respectively. 
    /// The return value should be an int, the maximum total strength of your units that are not captured. 
    /// 
    /// Constraints 
    /// you and computer will have the same number of elements. 
    /// you and computer will contain between 1 and 50 elements, inclusive. 
    /// Each element of you and computer will be between 1 and 1000, inclusive. 
    /// </summary>
    public class PlayGame
    {
        public int SaveCreatures(int[] you, int[] computer)
        {
            Array.Sort(you);
            Array.Sort(computer);
            var total = 0;
            var i = you.Length - 1;
            for (int j = i; j >= 0; j--)
            {
                while (i >= 0 && you[j] <= computer[i])
                {
                    i--;
                }
                if (i >= 0)
                {
                    i--;
                    total += you[j];
                }
            }
            return total;
        }
    }
}
