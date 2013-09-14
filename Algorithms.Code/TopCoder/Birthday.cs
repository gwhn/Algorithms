using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Forgetting a close friend's birthday is quite embarrassing, 
    /// but forgetting it two years in a row is a catastrophe. 
    /// So what can a coder do to prevent this from happening again? 
    /// Well, the thing he possibly can do best: code...  
    /// Given a String date (the current date) and a String[] birthdays, 
    /// a list of people's birthdays and names, 
    /// return a String, the date of the next occurring birthday, 
    /// starting from the current date.  
    /// date is in the format "MM/DD" (quotes for clarity), 
    /// where MM represents the two-digit month and DD represents the two-digit day (leading zero if necessary). 
    /// Each element of birthdays is in the format "MM/DD <Name>" (quotes for clarity), 
    /// where MM/DD is the date of <Name>'s birthday. 
    /// <Name> is a sequence of characters from 'A'-'Z' and 'a'-'z'. 
    /// There is exactly one space character between the date and <Name>. 
    /// The date returned also has to be in the format "MM/DD" (quotes for clarity).
    /// 
    /// Constraints
    /// birthdays contains between 1 and 50 elements, inclusive.
    /// Each element of birthdays contains between 7 and 50 characters, inclusive.
    /// date and each element of birthdays follow the format described in the problem statement.
    /// All dates are legal dates and neither date nor any date in birthdays is the 29th of February.
    /// </summary>
    public class Birthday
    {
        public String GetNext(String date, String[] birthdays)
        {
            var split1 = date.Split('/');
            var m = Convert.ToInt32(split1[0]);
            var d = Convert.ToInt32(split1[1]);
            string next;
            var mm = 13;
            var md = 32;
            var cm = mm;
            var cd = md;
            foreach (var b in birthdays)
            {
                var split2 = b.Split(' ');
                var split3 = split2[0].Split('/');
                var bm = Convert.ToInt32(split3[0]);
                var bd = Convert.ToInt32(split3[1]);
                if ((bm >= m || (bm == m && bd >= d)) && (bm < cm && bd < cd))
                {
                    cm = bm;
                    cd = bd;
                }
                else if ((bm < m || (bm == m && bd < d)) && (bm < mm && bd < md))
                {
                    mm = bm;
                    md = bd;
                }
            }
            if (cm < 13 && cd < 32)
            {
                next = string.Format("{0}/{1}",
                                     cm.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0'),
                                     cd.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0'));
            }
            else
            {
                next = string.Format("{0}/{1}",
                                     mm.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0'),
                                     md.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0'));
            }
            return next;
        }
    }
}
