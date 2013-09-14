using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// You work for a very large company that markets many different products. 
    /// In some cases, one product you market competes with another. 
    /// To help deal with this situation you have split the intended consumers into two groups, namely Adults and Teenagers. 
    /// If your company markets 2 products that compete with each other, 
    /// selling one to Adults and the other to Teenagers will help maximize profits. 
    /// Given a list of the products that compete with each other, 
    /// you are going to determine whether all can be marketed such that no pair of competing products 
    /// are both sold to Teenagers or both sold to Adults. 
    /// If such an arrangement is not feasible your method will return -1. 
    /// Otherwise, it should return the number of possible ways of marketing all of the products.
    /// 
    /// The products will be given in a String[] compete whose kth element describes product k. 
    /// The kth element will be a single-space delimited list of integers. 
    /// These integers will refer to the products that the kth product competes with. 
    /// For example:compete = {"1 4","2","3","0",""}
    /// 
    /// The example above shows product 0 competes with 1 and 4, product 1 competes with 2, product 2 competes with 3, 
    /// and product 3 competes with 0. 
    /// Note, competition is symmetric so product 1 competing with product 2 means product 2 competes with product 1 as well.
    /// 
    /// Ways to market:
    /// 1) 0 to Teenagers, 1 to Adults, 2 to Teenagers, 3 to Adults, and 4 to Adults
    /// 2) 0 to Adults, 1 to Teenagers, 2 to Adults, 3 to Teenagers, and 4 to Teenagers
    /// 
    /// Your method would return 2.  
    /// 
    /// Constraints 
    /// compete will contain between 1 and 30 elements, inclusive. 
    /// Each element of compete will have between 0 and 50 characters, inclusive. 
    /// Each element of compete will be a single space delimited sequence of integers such that: 
    /// All of the integers are unique.
    /// Each integer contains no extra leading zeros.
    /// Each integer is between 0 and k-1 inclusive where k is the number of elements in compete.
    /// No element of compete contains leading or trailing whitespace. 
    /// Element i of compete will not contain the value i. 
    /// If i occurs in the jth element of compete, j will not occur in the ith element of compete. 
    /// </summary>
    public class Marketing
    {
        private bool[,] _matrix;
        private Choices[] _state;
        private bool _error;
        private enum Choices
        {
            Unknown,
            Adult,
            Teenager
        }

        public long HowMany(String[] compete)
        {
            _error = false;
            var n = compete.Length;
            _matrix = new bool[n,n];
            _state = Enumerable.Repeat(Choices.Unknown, n).ToArray();
            for (var i = 0; i < n; i++)
            {
                var split = compete[i].Split(' ');
                var m = split.Length;
                for (int j = 0; j < m; j++)
                {
                    if (!string.IsNullOrEmpty(split[j]))
                    {
                        var k = Convert.ToInt32(split[j]);
                        _matrix[i, k] = _matrix[k, i] = true;                        
                    }
                }
            }
            var count = 1;
            for (var i = 0; i < n; i++)
            {
                if (_state[i] == Choices.Unknown)
                {
                    Search(i, Choices.Adult, n);
                    if (_error)
                    {
                        return -1;
                    }
                    count *= 2;
                }
            }
            return count;
        }

        private void Search(int i, Choices c, int n)
        {
            if (_state[i] != Choices.Unknown)
            {
                if (_state[i] != c)
                {
                    _error = true;
                }
            }
            else
            {
                _state[i] = c;
                var other = c == Choices.Adult ? Choices.Teenager : Choices.Adult;
                for (var j = 0; j < n; j++)
                {
                    if (_matrix[i,j])
                    {
                        Search(j, other, n);
                    }
                }
            }
        }
    }
}
