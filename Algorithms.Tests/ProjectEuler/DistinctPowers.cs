using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class DistinctPowers
    {
        private readonly Code.ProjectEuler.DistinctPowers _unit = new Code.ProjectEuler.DistinctPowers();

        [TestMethod]
        public void Test1()
        {
            const int a1 = 2;
            const int a2 = 5;
            const int b1 = 2;
            const int b2 = 5;
            var result = _unit.Solve(a1, a2, b1, b2);
            Assert.IsTrue(result == 15);
        }

        [TestMethod]
        public void Test2()
        {
            const int a1 = 2;
            const int a2 = 100;
            const int b1 = 2;
            const int b2 = 100;
            var result = _unit.Solve(a1, a2, b1, b2);
            Assert.IsTrue(result == 9183);
        }
    }
}
