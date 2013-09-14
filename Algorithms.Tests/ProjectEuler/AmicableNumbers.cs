using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.ProjectEuler
{
    [TestClass]
    public class AmicableNumbers
    {
        private readonly Code.ProjectEuler.AmicableNumbers _unit = new Code.ProjectEuler.AmicableNumbers();

        [TestMethod]
        public void Test1()
        {
            const int n = 10000;
            var result = _unit.Solve(n);
            Assert.IsTrue(result == 31626);
        }
    }
}
