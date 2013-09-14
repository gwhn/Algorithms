using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You are a director of a school, having an assembly for your kids. 
    /// The assembly is on the topic of consistency, and as a demonstration, 
    /// you want to hand out a number of jelly beans to each kid, 
    /// and have all the jelly beans that an individual kid receives be the same color 
    /// (one kid's color may be different than another kid's color). 
    /// At the store, each bag of jelly beans contains exactly 20 beans, 
    /// and each bean can be one of 5 colors. 
    /// The bags are opaque, so you cannot determine ahead of time exactly 
    /// how many of each color bean are in each bag 
    /// (a bag could have any combination of the 5 colors, including 20 of one color). 
    /// Given an int kids (the number of children) and an int quantity 
    /// (the number of beans you want to give each kid), 
    /// return how many bags of jelly beans you must buy 
    /// to ensure that you have enough jelly beans 
    /// to give each individual kid quantity same-colored beans. 
    /// 
    /// Constraints 
    /// kids will be between 1 and 1000, inclusive. 
    /// quantity will be between 2 and 25, inclusive. 
    /// </summary>
    public class SchoolAssembly
    {
        public int GetBeans(int kids, int quantity)
        {
            var t = (quantity - 1)*4;
            var c = kids*quantity;
            var x = t + c;
            var y = x/20;
            if (x%20 == 0)
            {
                return y;
            }
            return y + 1;
        }
    }
}
