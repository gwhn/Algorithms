using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
    /// 21 22 23 24 25
    /// 20  7  8  9 10
    /// 19  6  1  2 11
    /// 18  5  4  3 12
    /// 17 16 15 14 13
    /// It can be verified that the sum of the numbers on the diagonals is 101.
    /// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
    /// </summary>
    public class NumberSpiralDiagonals
    {
        private enum Direction
        {
            Left,
            Down,
            Right,
            Up
        };

        public int Solve(int n)
        {
            var i = n*n;
            var direction = Direction.Left;
            var spiral = new int[n,n];
            var x = n - 1;
            var y = 0;
            do
            {
                spiral[y, x] = i--;
                switch (direction)
                {
                    case Direction.Left:
                        if (--x < 0 || spiral[y, x] != 0)
                        {
                            direction = Direction.Down;
                            x++;
                            y++;
                        }
                        break;
                    case Direction.Down:
                        if (++y >= n || spiral[y, x] != 0)
                        {
                            direction = Direction.Right;
                            x++;
                            y--;
                        }
                        break;
                    case Direction.Right:
                        if (++x >= n || spiral[y, x] != 0)
                        {
                            direction = Direction.Up;
                            x--;
                            y--;
                        }
                        break;
                    case Direction.Up:
                        if (--y < 0 || spiral[y, x] != 0)
                        {
                            direction = Direction.Left;
                            x--;
                            y++;
                        }
                        break;
                }
            } while (i > 0);
            var sum = 0;
            for (int j = 0, k = n - 1; j < n && k >= 0; j++, k--)
            {
                sum += spiral[j, j] + spiral[j, k];
            }
            return sum - 1;
        }
    }
}
