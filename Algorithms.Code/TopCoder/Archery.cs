using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// In archery, you shoot an arrow at a target and you get some number of points depending 
    /// on where the arrow hits the target. 
    /// In this problem, the target is a circle divided into N concentric rings and a central circle. 
    /// The width of each ring and the radius of the central circle are equal. 
    /// The point values assigned to each section of the target are given in the int[] ringPoints. 
    /// The values are given in order, from innermost to outermost section, 
    /// so ringPoints[0] is the number of points you get for hitting the central circle, 
    /// and ringPoints[N] is the number of points you get for hitting the outermost ring. 
    /// You are a beginning archer. 
    /// Whenever you take a shot, the arrow always lands somewhere on the target, 
    /// but it hits a random point, and all points on the target have an equal probability of being hit. 
    /// Return the expected point value of your shot.
    /// 
    /// Notes
    /// The probability of hitting a specific section of the target is defined as the area of the 
    /// section divided by the total area of the target.
    /// The expected point value of a shot is calculated as follows. 
    /// For each section of the target, multiply its point value by the probability of hitting that section. 
    /// The expected point value is the sum of all these values.
    /// The returned value must have an absolute or relative error less than 1e-9.
    /// 
    /// Constraints
    /// N will be between 1 and 49, inclusive.
    /// ringPoints will contain exactly N+1 elements.
    /// Each element of ringPoints will be between 0 and 100, inclusive.
    /// </summary>
    public class Archery
    {
        public double ExpectedPoints(int N, int[] ringPoints)
        {
            var m = ringPoints.Length;
            var areas = new double[m];
            for (int i = 0; i < m; i++)
            {
                areas[i] = (Math.PI * Math.Pow(i + 1, 2)) - (Math.PI * Math.Pow(i, 2));
            }
            var total = areas.Sum();
            var probabilities = new double[m];
            for (int i = 0; i < m; i++)
            {
                probabilities[i] = areas[i]/total;
            }
            var points = 0.0D;
            for (int i = 0; i < m; i++)
            {
                points += ringPoints[i]*probabilities[i];
            }
            return points;
        }
    }
}
