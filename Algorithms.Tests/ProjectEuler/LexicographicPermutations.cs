using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class LexicographicPermutations
    {
        private readonly Code.ProjectEuler.LexicographicPermutations _unit = new Code.ProjectEuler.LexicographicPermutations();

        [TestMethod]
        public void Test1()
        {
            const int t = 5;
            var s = new[] {0, 1, 2};
            var result = _unit.Solve(s, t);
            Assert.IsTrue(result == "201");
        }

        [TestMethod]
        public void Test2()
        {
            const int t = 1000000;
            var s = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var result = _unit.Solve(s, t);
            Assert.IsTrue(result == "2783915460");
        }
    }
}
