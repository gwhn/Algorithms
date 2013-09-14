using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// The digits 3 and 9 share an interesting property. 
    /// If you take any multiple of 3 and sum its digits, you get another multiple of 3. 
    /// For example, 118*3 = 354 and 3+5+4 = 12, which is a multiple of 3. 
    /// Similarly, if you take any multiple of 9 and sum its digits, you get another multiple of 9. 
    /// For example, 75*9 = 675 and 6+7+5 = 18, which is a multiple of 9. 
    /// Call any digit for which this property holds interesting, except for 0 and 1, for which the property holds trivially.
    /// A digit that is interesting in one base is not necessarily interesting in another base. 
    /// For example, 3 is interesting in base 10 but uninteresting in base 5. 
    /// Given an int base, your task is to return all the interesting digits for that base in increasing order. 
    /// To determine whether a particular digit is interesting or not, 
    /// you need not consider all multiples of the digit. 
    /// You can be certain that, if the property holds for all multiples of the digit with fewer than four digits, 
    /// then it also holds for multiples with more digits. 
    /// For example, in base 10, you would not need to consider any multiples greater than 999.
    /// 
    /// Notes
    /// When base is greater than 10, digits may have a numeric value greater than 9. 
    /// Because integers are displayed in base 10 by default, do not be alarmed when such digits appear on your screen 
    /// as more than one decimal digit. 
    /// For example, one of the interesting digits in base 16 is 15.
    /// 
    /// Constraints
    /// base is between 3 and 30, inclusive.
    /// </summary>
    public class InterestingDigits
    {
        public int[] Digits(int b)
        {
            var res = new List<int>();
            for (var i = 2; i < b; ++i)
            {
                bool ok = true;
                for (int c = 1; c < 1000; ++c)
                {
                    ok = ok && Check(c * i, i, b);
                    if (!ok)
                        break;
                }
                if (ok)
                    res.Add(i);
            }
            var r = new int[res.Count];
            res.CopyTo(r);
            return r;
        }

        private static bool Check(int num, int d, int b)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % b;
                num /= b;
            }
            return sum % d == 0;
        }

        //public int[] Digits(int @base)
        //{
        //    var numbers = new List<int>();
        //    for (int i = 0; i < @base; i++)
        //    {
        //        for (int j = 0; j < @base; j++)
        //        {
        //            for (int k = 0; k < @base; k++)
        //            {
        //                for (int l = 0; l < @base; l++)
        //                {
        //                    var number = string.Format("{0}{1}{2}{3}", i, j, k, l).TrimStart('0');
        //                    if (number.Length > 0 && number.Length < 4)
        //                    {
        //                        numbers.Add(Int32.Parse(number));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    var result = new List<int>();
        //    for (int i = 2; i < @base; i++)
        //    {
        //        var interesting = true;
        //        for (int j = 1; j < numbers.Count; j++)
        //        {
        //            var m = numbers[j]*i;
        //            var n = m.ToString(CultureInfo.InvariantCulture);
        //            var sum = n.Sum(c => Int32.Parse(c.ToString(CultureInfo.InvariantCulture)));
        //            if (sum % i != 0)
        //            {
        //                interesting = false;
        //                break;
        //            }
        //        }
        //        if (interesting)
        //        {
        //            result.Add(i);
        //        }
        //    }
        //    result.Sort();
        //    return result.ToArray();
        //}
    }
}
