using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class CircularPrimes
    {
        private readonly Code.ProjectEuler.CircularPrimes _unit = new Code.ProjectEuler.CircularPrimes();

        [TestMethod]
        public void Test1()
        {
            const int max = 100;
            var result = _unit.Solve(max);
            Assert.IsTrue(result == 13);
        }

        [TestMethod]
        public void Test2()
        {
            const int max = 1000000;
            var result = _unit.Solve(max);
            Assert.IsTrue(result == 55);
        }
    }
}
