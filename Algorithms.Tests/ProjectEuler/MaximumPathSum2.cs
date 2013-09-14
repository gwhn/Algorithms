using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class MaximumPathSum2
    {
        private readonly Code.ProjectEuler.MaximumPathSum2 _unit = new Code.ProjectEuler.MaximumPathSum2();

        [TestMethod]
        public void Test1()
        {
            var triangle = new[]
                {
                    new[] {3},
                    new[] {7, 4},
                    new[] {2, 4, 6},
                    new[] {8, 5, 9, 3}
                };
            var result = _unit.Solve(triangle);
            Assert.IsTrue(result == 23);
        }

        [TestMethod]
        public void Test2()
        {
            const string path =
                @"C:\Users\guy\Documents\Visual Studio 2012\Projects\Algorithms\Algorithms.Tests\Resources\triangle.txt";
            var triangle = new List<int[]>();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        var split = line.Split(' ');
                        var n = split.Length;
                        var array = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            array[i] = Convert.ToInt32(split[i]);
                        }
                        triangle.Add(array);
                    }
                }

            }
            var result = _unit.Solve(triangle.ToArray());
            Assert.IsTrue(result == 7273);
        }
    }
}
