using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class HighlyDivisibleTriangularNumber
    {
        private readonly Code.ProjectEuler.HighlyDivisibleTriangularNumber _unit = new Code.ProjectEuler.HighlyDivisibleTriangularNumber();

        [TestMethod]
        public void Test1()
        {
            const int n = 5;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 28);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 500;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 76576500);
        }
    }
}
