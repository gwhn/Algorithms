using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class DigitFifthPowers
    {
        private readonly Code.ProjectEuler.DigitFifthPowers _unit = new Code.ProjectEuler.DigitFifthPowers();

        [TestMethod]
        public void Test1()
        {
            const int p = 4;
            var result = _unit.Solve(p);
            Assert.IsTrue(result == 19316);
        }

        [TestMethod]
        public void Test2()
        {
            const int p = 5;
            var result = _unit.Solve(p);
            Assert.IsTrue(result == 443839);
        }
    }
}
