﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code.ProjectEuler
{
    /// <summary>
    /// Triangle, pentagonal, and hexagonal numbers are generated by the following formulae:
    /// Triangle        Tn=n(n+1)/2     1, 3, 6, 10, 15, ... 
    /// Pentagonal      Pn=n(3n−1)/2    1, 5, 12, 22, 35, ... 
    /// Hexagonal       Hn=n(2n−1)      1, 6, 15, 28, 45, ... 
    /// It can be verified that T285 = P165 = H143 = 40755.
    /// Find the next triangle number that is also pentagonal and hexagonal.
    /// </summary>
    public class TriangularPentagonalAndHexagonal
    {
        public long Solve(int mint, int minp, int minh)
        {
            var triangles = new List<long>();
            var pentagonals = new List<long>();
            var hexagonals = new List<long>();
            var min = Math.Min(mint, Math.Min(minp, minh));
            for (var n = min; n < 100000; n++)
            {
                triangles.Add((n*(n + 1))/2);
                pentagonals.Add((n*((3*n) - 1))/2);
                hexagonals.Add(n*((2*n) - 1));
            }
            return triangles.Intersect(pentagonals).Intersect(hexagonals).First();
        }
    }
}