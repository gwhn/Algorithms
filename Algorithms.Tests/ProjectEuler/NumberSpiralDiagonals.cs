using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class NumberSpiralDiagonals
    {
        private readonly Code.ProjectEuler.NumberSpiralDiagonals _unit = new Code.ProjectEuler.NumberSpiralDiagonals();

        [TestMethod]
        public void Test1()
        {
            const int n = 5;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 101);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 1001;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 669171001);
        }
    }
}
