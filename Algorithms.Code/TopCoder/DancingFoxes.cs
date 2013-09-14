using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Fox Ciel and Fox Jiro both went to spend an evening in the dancing room. 
    /// Together, there are N foxes in the room. 
    /// The foxes are numbered 0 through N-1. In particular, Ciel is fox 0 and Jiro is fox 1. 
    /// You are given a String[] friendship that describes the initial friendship between the foxes in the room. 
    /// More precisely, friendship contains N elements with N characters each. 
    /// Character j of element i of friendship is 'Y' if foxes i and j are friends at the beginning of the evening, 
    /// and 'N' otherwise. Note that friendship is symmetric: whenever X is a friend of Y, Y is a friend of X. 
    /// During the evening, multiple songs will be played in succession. 
    /// During each song, some pairs of foxes will be dancing together. 
    /// Foxes are not allowed to change partners during the dance. 
    /// Thus in each dance each fox either dances with a single partner, or sits the dance out. 
    /// Foxes are not allowed to form the pairs for a dance arbitrarily. 
    /// It is only allowed for two foxes to dance together if they are friends, 
    /// or if they have a common friend who can introduce them. 
    /// That is, if foxes A and B are not friends at the moment, they can only dance together 
    /// if there is a fox C such that A and B are both friends with C. 
    /// After two foxes dance together, they become friends. 
    /// Fox Ciel wants to become friends with Fox Jiro. 
    /// Return the smallest number of dances in which this can be achieved 
    /// (assuming that all other foxes cooperate and form pairs for the dances optimally). 
    /// If it's impossible to make Ciel and Jiro friends, return -1 instead. 
    /// 
    /// Notes 
    /// Gender does not matter for the foxes when choosing their dance partners. 
    /// 
    /// Constraints 
    /// N will be between 2 and 50, inclusive. 
    /// friendship will contain exactly N elements. 
    /// Each element of friendship will contain exactly N characters. 
    /// Each character in friendship will be 'Y' or 'N'. 
    /// For each i, friendship[i][i] = 'N'. 
    /// For each i and j, friendship[i][j] = friendship[j][i]. 
    /// </summary>
    public class DancingFoxes
    {
        public int MinimalDays(String[] friendship)
        {
            var n = friendship.Length;
            var adj = new int[n,n];
            const int max = 1000;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    adj[i, j] = i == j ? 0 : friendship[i][j] == 'Y' ? 1 : max;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        adj[j, k] = Math.Min(adj[j, k], adj[j, i] + adj[i, k]);
                    }
                }
            }
            Print(adj);
            return adj[0, 1] == max
                       ? -1
                       : adj[0, 1] - 1;
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
