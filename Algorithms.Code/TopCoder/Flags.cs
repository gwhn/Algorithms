﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// I was asked to design 10 flags with vertical stripes using three colors: blue, orange, yellow. 
    /// I was asked not to have two neighboring stripes of the same color 
    /// (as a two-striped flag with two blue stripes looks exactly the same as a one-striped blue flag). 
    /// I was also asked not to have yellow and orange stripes next to each other as it doesn't look nice. 
    /// My goal was to minimize the number of stripes I need to use. 
    /// So, I can make 3 different one-striped flags. 
    /// I can make 4 different two-striped flags: blue-yellow, blue-orange, yellow-blue, orange-blue. 
    /// I can make 6 different three-striped flags: 
    ///     blue-yellow-blue, 
    ///     yellow-blue-yellow, 
    ///     orange-blue-orange, 
    ///     blue-orange-blue, 
    ///     orange-blue-yellow, 
    ///     yellow-blue-orange. 
    /// That is, I can make 13 different flags using 3 stripes at most.
    /// Your task is, given the number of flags, numFlags, and a String[] forbidden describing the colors that may not neighbor each other, 
    /// return the minimum number of stripes you need to design the given number of different flags using at most that amount of stripes.
    /// In more detail:
    /// A String[] forbidden will be constructed in the following manner:
    /// the colors will be indexed from 0
    /// i-th element of forbidden will be the indices of colors that are not allowed to be neighbors of the i-th color
    /// each element of forbidden will be a single-space delimited list of numbers without trailing/leading spaces
    /// each element of forbidden will have numbers without leading zeroes in increasing order
    /// each color will be in the list of forbidden colors of itself
    /// rules for forbidden colors are symmetric: if the i-th color can't be a neighbor of the j-th color, 
    /// then the j-th color can't be a neighbor of the i-th color
    /// at least one pair of neighbors will not be forbidden (if all possible pairs are forbidden, then you can only make one-striped flags)
    /// 
    /// Notes
    /// the left part of the flag is attached to a pole, so red-white and white-red are considered two different flags
    /// 
    /// Constraints
    /// numFlags represents a number between 1 and 10^17 inclusive (Note: numFlags will fit in long)
    /// forbidden has between 2 and 10 elements inclusive
    /// each element of forbidden will have between 1 and 50 characters inclusive and will consist only of digits ('0'-'9') and spaces (' ')
    /// each element of forbidden will start and end with a digit, and will not have 2 spaces in a row
    /// each element of forbidden will have the indices of forbidden colors in increasing order, without leading zeroes. 
    /// Indices will be between 0 and the number of colors minus one inclusive
    /// each element of forbidden will include its own index and will represent a symmetrical relationship
    /// not all possible pairs of colors will be forbidden in forbidden
    /// </summary>
    public class Flags
    {
        public long NumStripes(String numFlags, String[] forbidden)
        {
            throw new NotImplementedException();
        }
    }
}
