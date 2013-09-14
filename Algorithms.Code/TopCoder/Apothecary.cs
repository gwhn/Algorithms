using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// An accurate scale is one of the most important tools of the apothecary (an old-time pharmacist). To measure the weight of an object, the apothecary places the object on one pan of the scale, along with some weights of known size, and adds more weights of known size to the other pan until the scales balance. For example, if an object weighs 17 grains, the apothecary could balance the scales by placing a 1-grain weight and a 9-grain weight in the pan with the object, and a 27-grain weight in the other pan. 
    /// The apothecary owns weights in a range of sizes starting at 1 grain. In particular, he owns one weight for each power of 3: 1 grain, 3 grains, 9 grains, 27 grains, etc. Determine, for an object weighing W grains, how to distribute the weights among the pans to balance the object. This distribution will be unique. Return a int[] of the weights used. The sign of each weight should be negative if the weight goes in the same pan as the object, and positive if it goes in the other pan. The int[] should be arranged in increasing order. 
    /// 
    /// Constraints 
    /// W is between 1 and 1000000, inclusive. 
    /// </summary>
    public class Apothecary
    {
        public int[] Balance(int W)
        {
            var list = new List<int>();
            var multiplier = 1;
            while (W > 0)
            {
                var remainder = W%3;
                if (remainder == 2)
                {
                    list.Add(-multiplier);
                    W += 1;
                }
                if (remainder == 1)
                {
                    list.Add(multiplier);
                    W -= 1;
                }
                multiplier *= 3;
                W /= 3;
            }
            list.Sort();
            return list.ToArray();
        }
    }
}
