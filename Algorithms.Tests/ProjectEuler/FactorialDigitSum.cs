using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class FactorialDigitSum
    {
        private readonly Code.ProjectEuler.FactorialDigitSum _unit = new Code.ProjectEuler.FactorialDigitSum();

        [TestMethod]
        public void Test1()
        {
            const int n = 10;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 27);
        }

        [TestMethod]
        public void Test2()
        {
            const int n = 100;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 648);
        }
    }
}
