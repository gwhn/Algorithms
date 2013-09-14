using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are writing firmware for an exercise machine. Each second, a routine in your firmware is called which decides 
    /// whether it should display the percentage of the workout completed. The display does not have any ability to show 
    /// decimal points, so the routine should only display a percentage if the second it is called results in a whole 
    /// percentage of the total workout.
    /// Given a String time representing how long the workout lasts, in the format "hours:minutes:seconds", return the 
    /// number of times a percentage will be displayed by the routine. 
    /// The machine should never display 0% or 100%.
    /// 
    /// Constraints
    /// time will be a String formatted as "HH:MM:SS", HH = hours, MM = minutes, SS = seconds.
    /// The hours portion of time will be an integer with exactly two digits, with a value between 00 and 23, inclusive.
    /// The minutes portion of time will be an integer with exactly two digits, with a value between 00 and 59, inclusive.
    /// The seconds portion of time will be an integer with exactly two digits, with a value between 00 and 59, inclusive
    /// time will not be "00:00:00".
    /// </summary>
    public class ExerciseMachine
    {
        public int GetPercentages(String time)
        {
            var secs = Convert.ToDecimal(CalculateSeconds(time));
            var spp = secs/100M;
            var c = 0;
            for (var i = 1; i < secs; i++)
            {
                if (i%spp == 0)
                {
                    c++;
                }
            }
            return c;
        }

        private static int CalculateSeconds(string time)
        {
            var es = time.Split(':');
            var h = Convert.ToInt32(es[0]);
            var m = Convert.ToInt32(es[1]);
            var s = Convert.ToInt32(es[2]);
            const int sim = 60;
            const int sih = sim*sim;
            var ts = s + (m*sim) + (h*sih);
            return ts;
        }
    }
}
