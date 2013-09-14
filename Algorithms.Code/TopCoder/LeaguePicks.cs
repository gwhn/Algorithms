using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You and your friends are setting up a fantasy TopCoder league, 
    /// where you choose coders to be on your team and 
    /// score points in the league when any one of your coders wins their room or 
    /// successfully challenges somebody, etc. 
    /// To be fair, a system has been developed to choose the order in which picks are distributed. 
    /// It works like this: first, lots are drawn to choose your position in the league. 
    /// Then the player with the first position gets first pick, the second player gets second pick, 
    /// all the way until the last player picks. 
    /// Then the order reverses: the last player chooses again, then the next to last player, and so on, 
    /// until you reach the first player again. 
    /// Then the cycle repeats: the first position chooses again, then the second, and so on.
    /// For example: say you were in the third position on a 6 player league. 
    /// You would get the 3rd pick, then you'd wait until the 10th pick (the order would be 1,2,you,4,5,6,6,5,4,you), 
    /// and then the 15th pick, and so on until there were no more coders to choose. 
    /// If there were 20 total picks, then you would get pick numbers 3,10,15.
    /// Not wanting to miss your chance at a pick, 
    /// your goal is to write a program that tells you what pick numbers you have in the order that you have them. 
    /// You will receive three ints indicating your position in the league (1 being the first position), 
    /// the number of friends that are in the league with you, 
    /// and the number of picks that are being divvied up among the league. 
    /// You will return an int[] that indicates the picks that you receive in ascending order.
    /// 
    /// Notes
    /// Note that your position in the league and the pick numbers start at 1 and not 0. This should be clear from the examples.
    /// 
    /// Constraints
    /// position will be between 1 and friends inclusive.
    /// friends will be between 1 and 40 inclusive.
    /// picks will be between 1 and 40 * friends inclusive.
    /// </summary>
    public class LeaguePicks
    {
        public int[] ReturnPicks(int position, int friends, int picks)
        {
            var list = new List<int>();
            var counter = 1;
            var reverse = false;
            for (var i = 1; i <= picks; i++)
            {
                if (counter == position)
                {
                    list.Add(i);
                }
                if (counter == friends && !reverse)
                {
                    reverse = true;
                    continue;
                }
                if (counter == 1 && reverse)
                {
                    reverse = false;
                    continue;
                }
                if (reverse)
                {
                    counter--;
                }
                else
                {
                    counter++;
                }
            }
            return list.ToArray();
        }
    }
}
