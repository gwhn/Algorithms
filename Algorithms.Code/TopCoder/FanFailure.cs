using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// In a robust computer system, one of the most important pieces is the cooling. 
    /// Without proper cooling, processors can heat up to over 400 degrees C. 
    /// The reliability of a system can be measured by determining 
    /// how many fans can fail without risking the system processor. 
    /// Each fan can be assigned a value indicating how much capacity it has to cool the system, 
    /// and we can define a minimum cooling capacity, 
    /// which the sum of the fan capacities must exceed to properly cool the system. 
    /// We define a Failure Set as a set of fans which are not necessary to cool the system. 
    /// In other words, if the fans in a Failure Set break, 
    /// the system can still be properly cooled by the remaining fans. 
    /// The count of a Failure Set is the number of fans in the set. 
    /// To measure the reliability, we will define two values, 
    /// the Maximum Failure Set (MFS) and the Maximum Failure Count (MFC). 
    /// A MFS is a Failure Set of fans with the largest count possible. 
    /// A set of fans may have more than one MFS (see below). 
    /// A Failure Set is an MFS if and only if there are no Failure Sets with a higher count. 
    /// The MFC is the largest value such that all fan sets with count &lt;= MFC are Failure Sets. 
    /// In other words, any set of fans of size MFC or less can fail, 
    /// and the system will still be properly cooled by the remaining fans. 
    /// Consider the fan set with capacities 1, 2, 3, and a cooling requirement of 2. 
    /// Two MFSs with a count of 2 exist: fans 1 and 3, or fans 1 and 2. 
    /// However, the MFC is not 2 because fans 2 and 3 is not a Failure set 
    /// (fan 1 could not cool the system properly by itself). 
    /// Thus, the MFC is 1, because if any single fan fails, the system can still be cooled. 
    /// You will be given a int[] capacities, which designates how many units of cooling each fan provides, 
    /// and an int minCooling, which designates the minimum units of cooling required to cool the system. 
    /// Your method should return a int[], 
    /// where the first value should be the number of fans in the Maximum Failure Set (MFS), 
    /// and the second value should be the Maximum Failure Count (MFC). 
    /// 
    /// Constraints 
    /// capacities has between 1 and 50 elements, inclusive. 
    /// each element of capacities is between 1 and 1000, inclusive. 
    /// minCooling is between 1 and 50000, inclusive. 
    /// The sum of all elements in capacities will be greater than or equal to minCooling. 
    /// </summary>
    public class FanFailure
    {
        public int[] GetRange(int[] capacities, int minCooling)
        {
            Array.Sort(capacities);
            int n = capacities.Length, 
                i, j, 
                sum = capacities.Sum(), 
                suma = sum, 
                sumb = sum;
            for (i = 0; i < n; i++)
            {
                suma -= capacities[i];
                if (suma < minCooling)
                {
                    break;
                }
            }
            for (j = n; j > 0; j--)
            {
                sumb -= capacities[j - 1];
                if (sumb < minCooling)
                {
                    break;
                }
            }
            return new[] {i, n - j};
        }
    }
}
