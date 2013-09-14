using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// F is a function that is defined on all real numbers from the closed interval [1,N]. 
    /// You are given a int[] Y with N elements. For each i (1 &lt;= i &lt;= N) we have F(i) = Y[i-1]. 
    /// Additionally, you know that F is piecewise linear: 
    ///     for each i, on the interval [i,i+1] F is a linear function. 
    /// The function F is uniquely determined by this information. 
    /// For example, if F(4)=1 and F(5)=6 then we must have F(4.7)=4.5. 
    /// As another example, this is the plot of the function F for Y = {1, 4, -1, 2}. 
    /// Given a real number y, we can count the number of solutions to the equation F(x)=y. 
    /// For example, for the function plotted above there are 0 solutions for y=7, 
    /// there is 1 solution for y=4, and there are 3 solutions for y=1.1. 
    /// We are looking for the largest number of solutions such an equation can have. 
    /// For the function plotted above the answer would be 3: 
    ///     there is no y such that F(x)=y has more than 3 solutions. 
    /// If there is an y such that the equation F(x)=y has infinitely many solutions, return -1. 
    /// Otherwise, return the maximum possible number of solutions such an equation may have.  
    /// 
    /// Constraints 
    /// Y will contain between 2 and 50 elements, inclusive. 
    /// Each element of Y will be between -1,000,000,000 and 1,000,000,000, inclusive. 
    /// </summary>
    public class PiecewiseLinearFunction
    {
        public int MaximumSolutions(int[] Y)
        {
            var n = Y.Length;
            var lines = new List<Line>();
            for (int i = 0; i < n - 1; i++)
            {
                var p1 = new Point(i + 1, Y[i]);
                var p2 = new Point(i + 2, Y[i + 1]);
                var line = new Line(p1, p2);
                lines.Add(line);
            }
            var min = Y.Min();
            var max = Y.Max();
            var count = 0;
            for (int i = min; i <= max; i++)
            {
                var solutions = 0;
                var p1 = new Point(1, i);
                var p2 = new Point(n, i);
                var line2 = new Line(p1, p2);
                foreach (var line1 in lines)
                {
                    var determinant = line1.Determinant(line2);
                    if (determinant <= 0.0D + 1e-9 &&
                        determinant >= 0.0D - 1e-9)
                    {
                        return -1;
                    }
                    if (line1.Intersect(line2))
                    {
                        solutions++;
                    }
                }
                count = Math.Max(count, solutions);
            }
            return count;
        }
    }

    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    class Line
    {
        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
            A = p2.Y - p1.Y;
            B = p1.X - p2.X;
            C = A*p1.X + B*p1.Y;
        }

        public double Determinant(Line other)
        {
            return A*other.B - other.A*B;
        }

        public bool Intersect(Line other)
        {
            var determinant = Determinant(other);
            if (determinant >= 0.0D - 1e-9 && determinant <= 0.0D + 1e-9)
            {
                return false; // parallel
            }
            var x = (other.B*C - B*other.C)/determinant;
            var y = (A*other.C - other.A*C)/determinant;
            return x >= Math.Min(P1.X, P2.X) && x <= Math.Max(P1.X, P2.X) &&
                   y >= Math.Min(P1.Y, P2.Y) && y <= Math.Max(P1.Y, P2.Y);
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Point P1 { get; private set; }
        public Point P2 { get; private set; }
    }
}
