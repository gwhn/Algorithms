using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Recently you have been working on the pathfinding module for your AI system. 
    /// Your objective is to find the shortest path for an agent that wants to travel between two points on a plane. 
    /// The agent will start at the point (0,0), and travel to the point (x,y). 
    /// You decided that the agent will move either on horizontal of vertical lines such that, at every moment, 
    /// at least one coordinate of the agent is an integer.
    /// There is yet another restriction however. 
    /// Each line will only allow movement in one direction. 
    /// All horizontal lines with odd y-coordinates will be directed toward decreasing values of x, 
    /// and all other horizontal lines toward increasing values of x. 
    /// Similarly, all vertical lines with odd x-coordinates will be directed toward decreasing values of y, 
    /// and all other vertical lines toward increasing values of y.
    /// Given x and y, return the distance that the agent must travel.
    /// 
    /// Constraints
    /// x and y will both be between -10^6 and 10^6, inclusive.
    /// </summary>
    public class Pathfinding
    {
        public int GetDirections(int x, int y)
        {
            var visited = new Dictionary<Point, bool>();
            var queue = new Queue<Node>();
            var origin = new Point(0, 0);
            var destination = new Point(x, y);
            queue.Enqueue(new Node(origin, 0));
            while (queue.Count > 0)
            {
                var head = queue.Dequeue();
                if (visited.ContainsKey(head.Point))
                {
                    continue;
                }
                visited[head.Point] = true;
                if (head.Point.Equals(destination))
                {
                    return head.Steps;
                }
                if (head.Point.X % 2 == 0)
                {
                    queue.Enqueue(new Node(new Point(head.Point.X, head.Point.Y + 1), head.Steps + 1));
                }
                else
                {
                    queue.Enqueue(new Node(new Point(head.Point.X, head.Point.Y - 1), head.Steps + 1));
                }
                if (head.Point.Y % 2 == 0)
                {
                    queue.Enqueue(new Node(new Point(head.Point.X + 1, head.Point.Y), head.Steps + 1));
                }
                else
                {
                    queue.Enqueue(new Node(new Point(head.Point.X - 1, head.Point.Y), head.Steps + 1));
                }
            }
            return -1;
        }

        private class Point
        {
            private bool Equals(Point other)
            {
                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((Point) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X*397) ^ Y;
                }
            }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; private set; }
            public int Y { get; private set; }
        }

        private class Node
        {
            public Node(Point point, int steps)
            {
                Point = point;
                Steps = steps;
            }

            public Point Point { get; private set; }
            public int Steps { get; private set; }
        }
    }
}
