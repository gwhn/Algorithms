using System;
using System.Collections.Generic;

namespace Algorithms.Code
{
    /// <summary>
    ///     You might remember the old computer arcade games. Here is one about Manao.
    ///     The game level is an NxM grid of equal cells.
    ///     The bottom of some cells has a platform at which Manao can stand.
    ///     All the cells in the bottommost row contain a platform, thus covering the whole ground of the level.
    ///     The rows of the grid are numbered from 1 to N starting from the top and the columns are numbered
    ///     from 1 to M starting from the left.
    ///     Exactly one cell contains a coin and Manao needs to obtain it.
    ///     Initially, Manao is standing on the ground, i.e., in the bottommost row.
    ///     He can move between two horizontally adjacent cells if both contain a platform.
    ///     Also, Manao has a ladder which he can use to climb.
    ///     He can use the ladder to climb both up and down.
    ///     If the ladder is L units long, Manao can climb between two cells (i1, j) and (i2, j)
    ///     if both contain a platform and |i1-i2| &lt;= L.
    ///     Note that Manao carries the ladder along, so he can use it multiple times.
    ///     You need to determine the minimum ladder length L which is sufficient to acquire the coin.
    ///     You are given a int[] level containing N elements.
    ///     The j-th character in the i-th row of level is 'X' if cell (i+1, j+1) contains a platform and '.' otherwise.
    ///     You are also given ints coinRow and coinColumn.
    ///     The coin which Manao seeks is located in cell (coinRow, coinColumn) and
    ///     it is guaranteed that this cell contains a platform.
    ///     Return the minimum L such that ladder of length L is enough to get the coin.
    ///     If Manao can perform the task without using the ladder, return 0.
    ///     Notes
    ///     Manao is not allowed to fall. The only way in which he may change his vertical coordinate is by using the ladder.
    ///     Constraints
    ///     level will contain N elements, where N is between 1 and 50, inclusive.
    ///     Each element of level will be M characters long, where M is between 1 and 50, inclusive.
    ///     Each element of level will consist of '.' and 'X' characters only.
    ///     The last element of level will be entirely filled with 'X'.
    ///     coinRow will be between 1 and N, inclusive.
    ///     coinColumn will be between 1 and M, inclusive.
    ///     level[coinRow - 1][coinColumn - 1] will be 'X'.
    /// </summary>
    public class ArcadeManao
    {
        public int ShortestLadder(String[] level, int coinRow, int coinColumn)
        {
            int h = level.Length;
            int w = level[0].Length;
            var v = new bool[w,h];
            v[0, h - 1] = true;
            for (int l = 0; l < h; l++)
            {
                var q = new Queue<Tuple<int, int>>();
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        if (v[x,y])
                        {
                            q.Enqueue(new Tuple<int, int>(x, y));                            
                        }
                    }
                }
                while (q.Count > 0)
                {
                    Tuple<int, int> n = q.Dequeue();
                    int x = n.Item1;
                    int y = n.Item2;
                    for (int i = -1; i < 2; i += 2)
                    {
                        int dx = x + i;
                        if (dx < 0 || dx >= w)
                        {
                            continue;
                        }
                        if (v[dx, y])
                        {
                            continue;
                        }
                        if (level[y][dx] != 'X')
                        {
                            continue;
                        }
                        v[dx, y] = true;
                        q.Enqueue(new Tuple<int, int>(dx, y));
                    }
                    for (int i = -l; i <= l; i++)
                    {
                        int dy = y + i;
                        if (dy < 0 || dy >= h)
                        {
                            continue;
                        }
                        if (v[x, dy])
                        {
                            continue;
                        }
                        if (level[dy][x] != 'X')
                        {
                            continue;
                        }
                        v[x, dy] = true;
                        q.Enqueue(new Tuple<int, int>(x, dy));
                    }
                }
                if (v[coinColumn - 1, coinRow - 1])
                {
                    return l;
                }
            }
            return -1;
        }
    }
}
