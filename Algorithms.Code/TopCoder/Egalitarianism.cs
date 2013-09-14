using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// A kingdom has n citizens. Each one has some amount of money, a number of dollars denoted by a non-negative integer. 
    /// Citizens are numbered from 0 to n-1. Some citizens have friends. 
    /// Their friendship network is described by a String[] called isFriend, 
    /// such that if isFriend[i][j] == 'Y', the citizens numbered i and j are friends, and if isFriend[i][j] == 'N', 
    /// these citizens are not friends. 
    /// The king decrees the following: 
    /// Each citizen's amount of money must be within d dollars of the amount of money belonging to any of his friends. 
    /// In other words, a citizen with x dollars must not have any friends with less than x-d dollars or more than x+d dollars. 
    /// Given the number of citizens and their friendship network, 
    /// what is the greatest possible money difference between any two people (not necessarily friends) in this kingdom? 
    /// If there is a finite answer, return it. Otherwise, return -1. 
    /// 
    /// Constraints 
    /// n will be between 2 and 50, inclusive. 
    /// d will be between 0 and 1,000, inclusive. 
    /// isFriend will contain exactly n elements. 
    /// Each element of isFriend will contain exactly n characters, each of which is either 'Y' or 'N'. 
    /// For any i, isFriend[i][i] = 'N'. 
    /// For any i and j, isFriend[i][j] = isFriend[j][i]. 
    /// </summary>
    public class Egalitarianism
    {
        public int MaxDifference(String[] isFriend, int d)
        {
            var n = isFriend.Length;
            var matrix = new int[n,n];
            const int max = 1000;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    matrix[i, j] = i == j
                                       ? 0
                                       : isFriend[i][j] == 'Y'
                                             ? 1
                                             : max;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix[j, k] = Math.Min(matrix[j, k], matrix[j, i] + matrix[i, k]);
                        Print(matrix);
                    }
                }
            }
            var m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i,j] == max)
                    {
                        return -1;
                    }
                    m = Math.Max(m, matrix[i, j]);
                }
            }
            return m*d;
        }

        private void Print(int[,] matrix)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j].ToString(CultureInfo.InvariantCulture).PadLeft(5));
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
