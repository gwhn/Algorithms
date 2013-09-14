using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class NonAbundantSums
    {
        private readonly Code.ProjectEuler.NonAbundantSums _unit = new Code.ProjectEuler.NonAbundantSums();

        [TestMethod]
        public void Test1()
        {
            const int limit = 28123;
            var result = _unit.Solve(limit);
            Assert.IsTrue(result == 4179871);
        }
    }
}
