using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Given the width and height of a rectangular grid, return the total number of rectangles (NOT counting squares) 
    /// that can be found on this grid.
    /// For example, width = 3, height = 3 (see diagram below):
    ///  __ __ __
    /// |__|__|__|
    /// |__|__|__|
    /// |__|__|__|
    /// In this grid, there are 4 2x3 rectangles, 6 1x3 rectangles and 12 1x2 rectangles. 
    /// Thus there is a total of 4 + 6 + 12 = 22 rectangles. 
    /// Note we don't count 1x1, 2x2 and 3x3 rectangles because they are squares.
    /// 
    /// Notes
    /// rectangles with equals sides (squares) should not be counted.
    /// 
    /// Constraints
    /// width and height will be between 1 and 1000 inclusive.
    /// </summary>
    public class RectangularGrid
    {
        public long CountRectangles(int width, int height)
        {
            long c = 0;
            for (var i = 1; i <= width; i++)
            {
                for (var j = height; j > 0; j--)
                {
                    if (i != j)
                    {
                        var v = ((width - i) + 1) * ((height - j) + 1);
                        c += v;
                    }
                }
            }
            return c;
        }
    }
}
