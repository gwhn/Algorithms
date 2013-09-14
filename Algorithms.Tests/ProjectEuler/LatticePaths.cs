using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class LatticePaths
    {
        private readonly Code.ProjectEuler.LatticePaths _unit = new Code.ProjectEuler.LatticePaths();

        [TestMethod]
        public void Test1()
        {
            const int n = 4;
            const int k = 2;
            var result = _unit.Solve(n, k);
            Assert.IsTrue(result == 6);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 40;
            const int k = 20;
            var result = _unit.Solve(n, k);
            Assert.IsTrue(result == 137846528820);
        }
    }
}
