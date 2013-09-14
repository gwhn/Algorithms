using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// An essential part of circuit design and general system optimization is critical path analysis. 
    /// On a chip, the critical path represents the longest path any signal would have to travel during execution. 
    /// In this problem we will be analyzing chip designs to determine their critical path length. 
    /// The chips in this problem will not contain any cycles, i.e. there exists no path from one component of a chip back to itself.
    /// 
    /// Given a String[] connects representing the wiring scheme, and a String[] costs representing the cost of each connection, 
    /// your method will return the size of the most costly path between any 2 components on the chip. 
    /// In other words, you are to find the longest path in a directed, acyclic graph. 
    /// Element j of connects will list the components of the chip that can be reached directly from the jth component (0-based). 
    /// Element j of costs will list the costs of each connection mentioned in the jth element of connects. 
    /// As mentioned above, the chip will not contain any cyclic paths. 
    /// For example:
    ///     connects = {"1 2","2",""}
    ///     costs    = {"5 3","7",""}
    /// In this example, component 0 connects to components 1 and 2 with costs 5 and 3 respectively. 
    /// Component 1 connects to component 2 with a cost of 7. All connections mentioned are directed. 
    /// This means a connection from component i to component j does not imply a connection from component j to component i. 
    /// Since we are looking for the longest path between any 2 components, your method would return 12.  
    ///   
    /// Constraints 
    /// connects must contain between 2 and 50 elements inclusive 
    /// connects must contain the same number of elements as costs 
    /// Each element of connects must contain between 0 and 50 characters inclusive 
    /// Each element of costs must contain between 0 and 50 characters inclusive 
    /// Element i of connects must contain the same number of integers as element i of costs 
    /// Each integer in each element of connects must be between 0 and the size of connects-1 inclusive 
    /// Each integer in each element of costs must be between 1 and 1000 inclusive 
    /// Each element of connects may not contain repeated integers 
    /// Each element of connects must be a single space delimited list of integers, each of which has no extra leading zeros. There will be no leading or trailing whitespace. 
    /// Each element of costs must be a single space delimited list of integers, each of which has no extra leading zeros. There will be no leading or trailing whitespace. 
    /// The circuit may not contain any cycles 
    /// </summary>
    public class Circuits
    {
        public int HowLong(String[] connects, String[] costs)
        {
            var n = connects.Length;
            var matrix = new int[n,n];
            for (var i = 0; i < n; i++)
            {
                if (!string.IsNullOrEmpty(connects[i]))
                {
                    var split1 = connects[i].Split();
                    var split2 = costs[i].Split();
                    var m = split1.Length;
                    for (var j = 0; j < m; j++)
                    {
                        var k = Convert.ToInt32(split1[j]);
                        var l = Convert.ToInt32(split2[j]);
                        if (l > matrix[i, k])
                        {
                            matrix[i, k] = l;
                        }
                    }
                }
            }
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    for (var k = 0; k < n; k++)
                    {
                        if (matrix[j,i] != 0 && matrix[i,k] != 0)
                        {
                            if (matrix[j,k] < matrix[j,i] + matrix[i,k])
                            {
                                matrix[j, k] = matrix[j, i] + matrix[i, k];
                            }
                        }
                    }
                }
            }
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i,j] > result)
                    {
                        result = matrix[i, j];
                    }
                }
            }
            return result;
        }
    }
}
